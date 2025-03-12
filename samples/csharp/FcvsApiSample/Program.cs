/*
 * Copyright © 2019 Federation of State Medical Boards
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
 * documentation files (the “Software”), to deal in the Software without restriction, including without limitation the
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
 * persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Fsmb.Api.Fcvs.Client;
using Fsmb.Api.Fcvs.Client.Models;

namespace Fsmb.Api.Fcvs.ApiSample
{
    class Program
    {
        static void Main ( string[] args )
        {
            var program = new Program();

            program.Run(args);
        }

        #region API Calls
        
        private FcvsClient CreateClient ( ProgramOptions options )
        {
            var credentials = new FcvsApiClientCredentials() {
                ClientId = options.ClientId,
                ClientSecret = options.ClientSecret,
            };

            //HttpClient requires the URL to end with a slash
            var httpClient = new HttpClient() {
                BaseAddress = new Uri(options.Url.EnsureEndsWith("/"))
            };

            return new FcvsClient(httpClient, credentials);
        }

        // Gets the profile of a FID
        private async Task GetCurrentProfileByFidAsync ( FcvsClient client, string fid, CancellationToken cancellationToken )
        {
            //Call API
            Terminal.WriteDebug($"Getting current profile for FID {fid}");

            var profile = await client.GetCurrentProfileAsync(_options.Board, fid, cancellationToken).ConfigureAwait(false);
            if (profile == null)
                Terminal.WriteWarning("No profile found");
            else
                Terminal.WriteObject("Profile", profile);
        }

        // Gets the status of a FID
        private async Task GetStatusByFidAsync ( FcvsClient client, string fid, CancellationToken cancellationToken )
        {
            //Call API
            Terminal.WriteDebug($"Getting status for FID {fid}");

            var status = await client.GetStatusAsync(_options.Board, fid, cancellationToken).ConfigureAwait(false);
            if (status == null)
                Terminal.WriteWarning("No profile found");
            else
                Terminal.WriteObject("Status", status);
        }
        #endregion

        #region Private Members        

        private Func<FcvsClient, Task> DisplayMenu ()
        {
            Terminal.WriteLine("\nFCVS API Options");
            Terminal.WriteLine("".PadLeft(20, '-'));

            Terminal.WriteLine("1) Get the current profile for a specific FID");
            Terminal.WriteLine("2) Get the status for a specific FID");
            Terminal.WriteLine("0) Quit");

            do
            {
                switch (Terminal.ReadKey(true).KeyChar)
                {
                    case '0': return OnQuitAsync;
                    case '1': return OnCurrentProfileByFidAsync;
                    case '2': return OnStatusByFidAsync;
                };
            } while (true);
        }

        private bool Initialize ( string[] args )
        {
            var options = ParseCommandLine(args);
            if (options == null)
            {
                ShowHelp();
                return false;
            };

            //Override defaults
            if (String.IsNullOrEmpty(options.Url))
            {
                var url = Terminal.ReadString($"URL? (press ENTER to use default of {ProgramOptions.DefaultUrl}) ");
                options.Url = String.IsNullOrEmpty(url) ? ProgramOptions.DefaultUrl : url;
            };

            if (String.IsNullOrEmpty(options.Board))
            {
                var board = Terminal.ReadString($"Board? (press ENTER to use default of {ProgramOptions.DefaultBoard}) ");
                options.Board = String.IsNullOrEmpty(board) ? ProgramOptions.DefaultBoard : board;
            };

            //Verify required values are set            
            if (String.IsNullOrEmpty(options.ClientId))
                options.ClientId = Terminal.ReadString("Client Id? ", allowEmptyStrings: false);

            if (String.IsNullOrEmpty(options.ClientSecret))
                options.ClientSecret = Terminal.ReadString("Client Secret? ", allowEmptyStrings: false);

            _options = options;

            _client = CreateClient(_options);
            return true;
        }

        private Task OnQuitAsync ( FcvsClient client )
        {
            _quit = true;

            return Task.CompletedTask;
        }

        private async Task OnCurrentProfileByFidAsync ( FcvsClient client )
        {
            try
            {
                //Get the FID
                var fid = Terminal.ReadString("FID (or ENTER to cancel)? ", allowEmptyStrings: true);
                if (String.IsNullOrEmpty(fid))
                    return;

                await GetCurrentProfileByFidAsync(client, fid, CancellationToken.None).ConfigureAwait(false);
            } catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
            };
        }

        private async Task OnStatusByFidAsync ( FcvsClient client )
        {
            try
            {
                //Get the FID
                var fid = Terminal.ReadString("FID (or ENTER to cancel)? ", allowEmptyStrings: true);
                if (String.IsNullOrEmpty(fid))
                    return;

                await GetStatusByFidAsync(client, fid, CancellationToken.None).ConfigureAwait(false);
            } catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
            };
        }

        private ProgramOptions ParseCommandLine ( string[] args )
        {
            var options = new ProgramOptions();

            Action<string> argumentAction = null;
            foreach (var arg in args)
            {
                var isSwitch = arg.StartsWithAny('-', '/');
                var argument = (isSwitch ? arg.Trim('-', '/').ToLower() : arg).Trim();

                var badArgument = false;

                if (isSwitch)
                {
                    switch (argument)
                    {
                        case "clientid": argumentAction = value => options.ClientId = value; break;
                        case "clientsecret": argumentAction = value => options.ClientSecret = value; break;
                        case "url": argumentAction = value => options.Url = value; break;
                        case "board": argumentAction = value => options.Board = value; break;
                        case "help": return null;

                        default: badArgument = true; break;
                    };
                } else if (argumentAction != null)
                {
                    argumentAction(arg);
                    argumentAction = null;
                } else
                    badArgument = true;

                if (badArgument)
                {
                    Terminal.WriteError($"Unknown argument '{arg}'");
                    return null;
                };
            };

            if (argumentAction != null)
            {
                Terminal.WriteError("No argument specified");
                return null;
            };

            return options;
        }

        private void Run ( string[] args )
        {
            try
            {
                if (!Initialize(args))
                    return;

                RunAsync().Wait();
            } catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
                throw;
            };
        }

        private async Task RunAsync ()
        {
            do
            {
                var handler = DisplayMenu();
                await handler(_client);
            } while (!_quit);
        }

        private void ShowHelp ()
        {
            Terminal.WriteLine("-clientId <id> where <id> is the client ID");
            Terminal.WriteLine("-clientSecret <secret> where <secret> is the client secret");
            Terminal.WriteLine($"-url <url> where <url> is the base URL (Default = {ProgramOptions.DefaultUrl})");
            Terminal.WriteLine($"-board <board> where <board> is the board code (Default = {ProgramOptions.DefaultBoard})");
        }
        
        private ITerminal Terminal => ConsoleTerminal.Default;

        private bool _quit;
        private ProgramOptions _options;
        private FcvsClient _client;
        #endregion
    }
}
