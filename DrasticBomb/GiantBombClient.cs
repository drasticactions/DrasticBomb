// <copyright file="GiantBombClient.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using DrasticBomb.Exceptions;
using DrasticBomb.Tools;
using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace DrasticBomb
{
    public class GiantBombClient
    {
        private string baseUrl = "https://www.giantbomb.com/";
        private HttpClient client;
        private string authToken;
        private string appName;

        public GiantBombClient(string authToken, HttpClient? client = null, string appName = "DrasticBomb")
        {
            if (string.IsNullOrEmpty(authToken))
            {
                throw new ArgumentNullException(nameof(authToken));
            }

            this.appName = appName;
            this.authToken = authToken;
            this.client = client ?? new HttpClient();
            var productValue = new ProductInfoHeaderValue("DrasticBomb", "1.0");
            this.client.DefaultRequestHeaders.UserAgent.Add(productValue);
        }

        public string AppName => this.appName;

        public async Task<T> GetAsync<T>(string endpoint, NameValueCollection? queryString = null, CancellationToken cancellationToken = default)
        {
            if (queryString is null)
            {
                queryString = new NameValueCollection();
            }

            this.ValidateQueries(queryString);

            var qString = queryString.ToQueryString();
            var uri = $"{this.baseUrl}{endpoint}{qString}";
            var response = await this.client.GetAsync(uri, cancellationToken: cancellationToken);
            return await response.Content.ReadFromJsonAsync<T>() ?? throw new GiantBombClientException($"Failed to parse: {endpoint}");
        }

        private void ValidateQueries(NameValueCollection queryString)
        {
            if (queryString["format"] is not null)
            {
                queryString["format"] = "json";
            }
            else
            {
                queryString.Add("format", "json");
            }

            if (queryString["api_key"] is not null)
            {
                queryString["api_key"] = this.authToken;
            }
            else
            {
                queryString.Add("api_key", this.authToken);
            }
        }
    }
}
