// <copyright file="VideoShowResponse.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using DrasticBomb.Models.Videos;
using System.Text.Json.Serialization;

namespace DrasticBomb.Models
{
    public class VideoShowResponse : BaseResposne
    {
        /// <summary>
        /// Gets or sets the Videos Results.
        /// <see cref="VideosResult"/>.
        /// </summary>
        [JsonPropertyName("results")]
        public VideosResult? Results { get; set; }
    }
}
