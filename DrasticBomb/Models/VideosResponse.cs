// <copyright file="VideosResponse.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace DrasticBomb.Models
{
    /// <summary>
    /// Video Response.
    /// </summary>
    public class VideosResponse : BaseResposne
    {
        /// <summary>
        /// Gets or sets the Videos Results.
        /// <see cref="VideosResult"/>.
        /// </summary>
        [JsonPropertyName("results")]
        public VideosResult[]? Results { get; set; }
    }
}
