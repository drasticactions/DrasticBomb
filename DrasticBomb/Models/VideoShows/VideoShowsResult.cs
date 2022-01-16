// <copyright file="VideoShowsResult.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace DrasticBomb.Models.VideoShows
{
    public class VideoShowsResult
    {
        [JsonPropertyName("api_detail_url")]
        public Uri? ApiDetailUrl { get; set; }

        [JsonPropertyName("site_detail_url")]
        public Uri? SiteDetailUrl { get; set; }

        [JsonPropertyName("deck")]
        public string? Deck { get; set; }

        [JsonPropertyName("guid")]
        public string? Guid { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("position")]
        public long Position { get; set; }

        [JsonPropertyName("display_nav")]
        public bool DisplayNav { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("image")]
        public Image? Image { get; set; }

        [JsonPropertyName("logo")]
        public Image? Logo { get; set; }

        [JsonPropertyName("latest")]
        public Videos.VideosResult[]? Latest { get; set; }

        [JsonPropertyName("premium")]
        public bool Premium { get; set; }

        [JsonPropertyName("api_videos_url")]
        public Uri? ApiVideosUrl { get; set; }
    }
}
