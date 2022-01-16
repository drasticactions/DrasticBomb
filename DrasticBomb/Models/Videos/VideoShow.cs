// <copyright file="VideoShow.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace DrasticBomb.Models
{
    public class VideoShow
    {
        [JsonPropertyName("api_detail_url")]
        public Uri? ApiDetailUrl { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("position")]
        public long Position { get; set; }

        [JsonPropertyName("site_detail_url")]
        public Uri? SiteDetailUrl { get; set; }

        [JsonPropertyName("image")]
        public Image? Image { get; set; }

        [JsonPropertyName("logo")]
        public Image? Logo { get; set; }
    }
}
