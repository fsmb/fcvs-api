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

using Fsmb.Apis.FCVS.Clients.Models;
using Newtonsoft.Json;

namespace Fsmb.Apis.FCVS.Clients.Http
{
    public class FcvsClient
    {
        public FcvsClient(HttpClient client, string accessToken)
        {
            if (client == null)
                throw new ArgumentNullException("client");
            if (accessToken == null)
                throw new ArgumentNullException("accessToken");

            _client = new Lazy<HttpClient>(() => client);
            _accessToken = accessToken;
        }


        public async Task<Profile> GetCurrentProfileAsync(string board, string fid, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var message = new HttpRequestMessage(HttpMethod.Get, $"{Client.BaseAddress}/v1/boards/{board}/practitioners/{fid}/profiles/current");
            message.Headers.TryAddWithoutValidation("Authorization", $"Bearer {_accessToken}");
            using (var response = await Client.SendAsync(message, cancellationToken))
            {
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Profile>(content);
            };
        }

        public async Task<PractitionerStatus> GetStatusAsync(string board, string fid, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var message = new HttpRequestMessage(HttpMethod.Get, $"{Client.BaseAddress}/v1/boards/{board}/practitioners/{fid}/status");
            message.Headers.TryAddWithoutValidation("Authorization", $"Bearer {_accessToken}");
            using (var response = await Client.SendAsync(message, cancellationToken))
            {
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PractitionerStatus>(content);
            };
        }

        private HttpClient Client => _client.Value;
        private readonly Lazy<HttpClient> _client;
        private readonly string _accessToken;
    }
}
