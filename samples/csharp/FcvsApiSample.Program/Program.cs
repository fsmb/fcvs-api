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

using Fsmb.Apis.FCVS.Clients.Http;
using Fsmb.Apis.FCVS.Utility;
using Newtonsoft.Json;

namespace Fsmb.Apis.FCVS
{
    class Program
    {
        public Program()
        {
            _client = new Lazy<FcvsClient>(CreateClient);
        }

        static void Main(string[] args)
        {
            var program = new Program();

            program.Run(args);
        }

        private void Run(string[] args)
        {
            try
            {
                if (!Initialize(args))
                    return;

                RunAsync().Wait();
            }
            catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
                throw;
            };
        }


        private bool Initialize(string[] args)
        {
            Terminal.WriteLine("Federation Credentials Verification Service API");
            Terminal.WriteLine();
            var options = ParseCommandLine(args);
            if (options == null)
            {
                ShowHelp();
                return false;
            };

            //Verify required values are set            
            if (String.IsNullOrEmpty(options.ClientId))
                options.ClientId = Terminal.ReadString("Client Id? ", allowEmptyStrings: false);

            if (String.IsNullOrEmpty(options.ClientSecret))
                options.ClientSecret = Terminal.ReadString("Client Secret? ", allowEmptyStrings: false);

            _options = options;
            return true;
        }

        private async Task RunAsync()
        {
            do
            {
                var handler = DisplayMenu();
                await handler(Client);
            } while (!_quit);
        }


        private ProgramOptions ParseCommandLine(string[] args)
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
                        case "url": argumentAction = value => options.BaseAddress = value; break;
                        case "help": return null;

                        default: badArgument = true; break;
                    };
                }
                else if (argumentAction != null)
                {
                    argumentAction(arg);
                    argumentAction = null;
                }
                else
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


        private Func<FcvsClient, Task> DisplayMenu()
        {
            Terminal.WriteLine("\nFCVS API Options. Select one of the following:");
            Terminal.WriteLine("".PadLeft(20, '-'));

            Terminal.WriteLine("1) Get status of the current FCVS Profile for a practitioner.");
            Terminal.WriteLine("2) Get current FCVS Profile for a practitioner.");
            Terminal.WriteLine("0) Quit");

            Terminal.WriteLine();
            do
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '0': return OnQuitAsync;
                    case '1': return OnStatusAsync;
                    case '2': return OnProfileAsync;
                };
            } while (true);
        }



        private Task OnQuitAsync(FcvsClient client)
        {
            _quit = true;

            return Task.CompletedTask;
        }

        private async Task OnStatusAsync(FcvsClient client)
        {
            try
            {
                //Get the FID
                Terminal.WriteLine("Get status");
                var fid = Terminal.ReadString("FID? (or ENTER to cancel) ", allowEmptyStrings: true);
                if (String.IsNullOrEmpty(fid))
                    return;

                await GetStatusAsync(client, fid).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
            };
        }

        private async Task OnProfileAsync(FcvsClient client)
        {
            try
            {
                //Get the FID
                Terminal.WriteLine("Get profile");
                var fid = Terminal.ReadString("FID? (or ENTER to cancel) ", allowEmptyStrings: true);
                if (String.IsNullOrEmpty(fid))
                    return;

                await GetCurrentProfileAsync(client, fid).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                e = e.Unwrap();

                Terminal.WriteError(e.Message);
            };
        }

        private async Task GetCurrentProfileAsync(FcvsClient client, string fid, CancellationToken cancellationToken = default(CancellationToken))
        {
            //Call API
            Terminal.WriteDebug($"Getting Current Profile for FID {fid}");
            try
            {
                var profile = await client.GetCurrentProfileAsync("me", fid, cancellationToken).ConfigureAwait(false);
                if (profile != null)
                    Terminal.WriteLine(JsonConvert.SerializeObject(profile, Formatting.Indented));
            }
            catch (Exception e)
            {
                e = e.Unwrap();
                Terminal.WriteError(e.Message);
            }

        }

        private async Task GetStatusAsync(FcvsClient client, string fid, CancellationToken cancellationToken = default(CancellationToken))
        {
            //Call API
            Terminal.WriteDebug($"Getting Status of Current Profile for FID {fid}");
            try
            {
                var status = await client.GetStatusAsync("me", fid, cancellationToken).ConfigureAwait(false);
                if (status != null)
                    Terminal.WriteLine(JsonConvert.SerializeObject(status, Formatting.Indented));
            }
            catch (Exception e)
            {
                e = e.Unwrap();
                Terminal.WriteError(e.Message);
            }

        }

        private FcvsClient CreateClient()
        {
            //Authenticate the client
            var credentials = GetAccessTokenAsync(_options.AuthenticationUrl, _options.ClientId, _options.ClientSecret).Result;

            //Create the client 
            var httpClient = new HttpClient() { BaseAddress = new Uri(_options.ApiUrl) };
            return new FcvsClient(httpClient, credentials);
        }

        /// <summary>Gets an access token for the given client.</summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private async Task<string> GetAccessTokenAsync(string authenticationUrl, string clientId, string clientSecret)
        {
            //Create a single instance of HttpClient per base address per application otherwise you can run out of resources
            var httpClient = new HttpClient() { BaseAddress = new Uri(authenticationUrl) };

            var client = new AuthenticationClient(httpClient);

            Terminal.WriteDebug("Authenticating user");

            var accessToken = await client.AuthenticateAsync(clientId, clientSecret, "fcvs.read").ConfigureAwait(false);
            Terminal.WriteLine();

            return accessToken;
        }

        private void ShowHelp()
        {
            Terminal.WriteLine("-clientId {id} where {id} is the client ID");
            Terminal.WriteLine("-clientSecret {secret} where {secret} is the client secret");
            Terminal.WriteLine("-url {url} where {url} is the base URL (default is https://services-fcvs-demo.fsmb.org)");
        }

        private readonly Lazy<FcvsClient> _client;

        private FcvsClient Client => _client.Value;

        private bool _quit;
        private ProgramOptions _options;
    }
}
