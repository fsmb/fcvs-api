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
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

using Fsmb.Api.Fcvs.Client.Models;
using Fsmb.Api.Fcvs.Client.OAuth;

namespace Fsmb.Api.Fcvs.Client
{    
    public class FcvsClient
    {
        #region Construction

        /// <summary>Initializes an instance of the <see cref="FcvsClient"/> class.</summary>
        protected FcvsClient ()
        {
        }

        /// <summary>Initializes an instance of the <see cref="FcvsClient"/> class.</summary>
        /// <param name="client">HTTP client to use</param>        
        public FcvsClient ( HttpClient client ) : this(client, null)
        {            
        }

        /// <summary>Initializes an instance of the <see cref="FcvsClient"/> class.</summary>
        /// <param name="clientUrl">Client URL.</param>
        /// <param name="credentials">Credentials to use.</param>
        public FcvsClient ( HttpClient client, FcvsApiClientCredentials credentials )
        {            
            Client = client ?? throw new ArgumentNullException(nameof(client));

            _credentials = credentials;
        }
        #endregion

        public virtual async Task<Profile> GetCurrentProfileAsync ( string board, string fid, CancellationToken cancellationToken = default )
        {
            VerifyStringArgument(board, nameof(board));
            VerifyStringArgument(fid, nameof(fid));

            var request = new HttpRequestMessage(HttpMethod.Get, $"v1/boards/{board}/practitioners/{fid}/profiles/current");
            
            await PrepareRequestAsync(request, cancellationToken).ConfigureAwait(false);

            using (var response = await SendRequestAsync(request, cancellationToken).ConfigureAwait(false))
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent || response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    return null;

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadFromJsonAsync<Profile>(cancellationToken).ConfigureAwait(false);
            };
        }

        public virtual async Task<PractitionerStatus> GetStatusAsync ( string board, string fid, CancellationToken cancellationToken = default )
        {
            VerifyStringArgument(board, nameof(board));
            VerifyStringArgument(fid, nameof(fid));

            var request = new HttpRequestMessage(HttpMethod.Get, $"v1/boards/{board}/practitioners/{fid}/status");

            await PrepareRequestAsync(request, cancellationToken).ConfigureAwait(false);

            using (var response = await SendRequestAsync(request, cancellationToken).ConfigureAwait(false))
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent || response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    return null;

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadFromJsonAsync<PractitionerStatus>(cancellationToken).ConfigureAwait(false);
            };
        }

        #region Protected Members

        /// <summary>Gets the underlying HTTP client.</summary>
        protected HttpClient Client { get; }

        protected async Task<OAuthAccessToken> GetAccessTokenAsync ( CancellationToken cancellationToken )
        {
            //If the access token is still valid then use it
            if ((_accessToken?.ExpirationDate ?? DateTime.MinValue).AddMinutes(5) > DateTime.Now)
                return _accessToken;

            _accessToken = await Client.AuthenticateAsync(_credentials, cancellationToken).ConfigureAwait(false);

            return _accessToken;
        }


        /// <summary>Prepare a request for sending.</summary>
        protected virtual async Task PrepareRequestAsync ( HttpRequestMessage request, CancellationToken cancellationToken )
        {
            if (_credentials != null)
            {
                var token = await GetAccessTokenAsync(cancellationToken).ConfigureAwait(false);

                request.WithBearerToken(token.AccessToken);
            };
        }

        protected virtual Task<HttpResponseMessage> SendRequestAsync ( HttpRequestMessage request, CancellationToken cancellationToken = default )
                        => Client.SendAsync(request, cancellationToken);

        /// <summary>Verifies a string argument is not <see langword="null"/> or empty.</summary>
        /// <param name="value">Argument value.</param>
        /// <param name="name">Argument name.</param>
        /// <exception cref="ArgumentNullException">Argument is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">Argument is empty.</exception>
        protected void VerifyStringArgument ( string value, string name )
        {
            if (value == null)
                throw new ArgumentNullException(name);
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be empty.", name);
        }
        #endregion

        #region Private Members

        private readonly FcvsApiClientCredentials _credentials;

        private OAuthAccessToken _accessToken;

        #endregion
    }
}
