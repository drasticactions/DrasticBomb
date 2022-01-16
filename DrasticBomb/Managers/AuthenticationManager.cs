// <copyright file="AuthenticationManager.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using DrasticBomb.Models;
using System.Collections.Specialized;

namespace DrasticBomb.Managers
{
    public class AuthenticationManager
    {
        private GiantBombClient client;

        public AuthenticationManager(GiantBombClient client)
        {
            this.client = client;
        }

        public string AuthenticationUrl => $"https://www.giantbomb.com/app/{this.client.AppName}/";

        public async Task<AuthenticationResult> GetSubscriberTokenAsync(string code, CancellationToken cancellationToken = default)
        {
            var nvc = new NameValueCollection();
            nvc.Add("regCode", code);
            return await this.client.GetAsync<AuthenticationResult>($"app/{this.client.AppName}/get-code", nvc, cancellationToken);
        }
    }
}
