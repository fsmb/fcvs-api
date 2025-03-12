/*
* Copyright © Federation of State Medical Boards
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
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Fsmb.Api.Fcvs.Client.OAuth
{
    /// <summary>Provides OAuth extensions for HTTP clients.</summary>
    public static class OAuthHttpExtensions
    {
        /// <summary>Authenticate using client credentials.</summary>
        /// <param name="client">Client</param>
        /// <param name="credentials">Client credentials</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Access token</returns>
        public static async Task<OAuthAccessToken> AuthenticateAsync ( this HttpClient client, OAuthClientCredentials credentials, CancellationToken cancellationToken = default )
        {            
            var body = new Dictionary<string, string>() {
                            { "client_id", credentials.ClientId },
                            { "client_secret", credentials.ClientSecret },                            
                            { "grant_type", "client_credentials"}
            };

            if (credentials.Scopes?.Any() ?? false)
                body["scope"] = String.Join(" ", credentials.Scopes);

            using (var content = new FormUrlEncodedContent(body))
            using (var response = await client.PostAsync(credentials.TokenUrl, content, cancellationToken).ConfigureAwait(false))
            {
                var token = await response.Content.ReadFromJsonAsync<AccessToken>(cancellationToken).ConfigureAwait(false);

                return new OAuthAccessToken() {
                    AccessToken = token.access_Token,
                    ExpirationDate = DateTime.Now.AddSeconds(token.expire_in)
                };
            };
        }

        /// <summary>Adds a bearer token to a request.</summary>
        /// <param name="request">Request</param>
        /// <param name="accessToken">Bearer token</param>
        /// <returns>Request</returns>
        public static HttpRequestMessage WithBearerToken ( this HttpRequestMessage request, string accessToken )
        {
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            return request;
        }

        #region Private Members

        private sealed class AccessToken
        {
            public string access_Token { get; set; }

            public int expire_in { get; set; }

            public string token_type { get; set; }
        }
        #endregion
    }
}