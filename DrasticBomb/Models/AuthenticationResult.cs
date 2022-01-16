// <copyright file="AuthenticationResult.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace DrasticBomb.Models
{
    public class AuthenticationResult
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("creationTime")]
        public string? CreationTime { get; set; }

        [JsonPropertyName("regToken")]
        public string? RegToken { get; set; }

        [JsonPropertyName("expiration")]
        public long Expiration { get; set; }

        [JsonPropertyName("customerId")]
        public string? CustomerId { get; set; }
    }
}
