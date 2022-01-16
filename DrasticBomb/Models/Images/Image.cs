// <copyright file="Image.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace DrasticBomb.Models
{
    public class Image
    {
        [JsonPropertyName("icon_url")]
        public Uri? IconUrl { get; set; }

        [JsonPropertyName("medium_url")]
        public Uri? MediumUrl { get; set; }

        [JsonPropertyName("screen_url")]
        public Uri? ScreenUrl { get; set; }

        [JsonPropertyName("screen_large_url")]
        public Uri? ScreenLargeUrl { get; set; }

        [JsonPropertyName("small_url")]
        public Uri? SmallUrl { get; set; }

        [JsonPropertyName("super_url")]
        public Uri? SuperUrl { get; set; }

        [JsonPropertyName("thumb_url")]
        public Uri? ThumbUrl { get; set; }

        [JsonPropertyName("tiny_url")]
        public Uri? TinyUrl { get; set; }

        [JsonPropertyName("original_url")]
        public Uri? OriginalUrl { get; set; }

        [JsonPropertyName("image_tags")]
        public string? ImageTags { get; set; }
    }
}
