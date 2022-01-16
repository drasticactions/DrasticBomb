// <copyright file="VideoShowsResponse.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using DrasticBomb.Models.VideoShows;
using System.Text.Json.Serialization;

namespace DrasticBomb.Models
{
    public class VideoShowsResponse : BaseResposne
    {
        /// <summary>
        /// Gets or sets the Videos Results.
        /// <see cref="VideosResult"/>.
        /// </summary>
        [JsonPropertyName("results")]
        public VideoShowsResult[]? Results { get; set; }
    }
}
