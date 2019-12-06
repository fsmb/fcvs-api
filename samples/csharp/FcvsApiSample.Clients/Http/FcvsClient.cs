using Fsmb.Apis.FCVS.Clients.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

            var message = new HttpRequestMessage(HttpMethod.Get, Client.BaseAddress + $"/v1/boards/{board}/practitioners/{fid}/profiles/current");
            message.Headers.TryAddWithoutValidation("Bearer", _accessToken);
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

            var message = new HttpRequestMessage(HttpMethod.Get, Client.BaseAddress + $"/v1/boards/{board}/practitioners/{fid}/status");
            message.Headers.TryAddWithoutValidation("Bearer", _accessToken);
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
