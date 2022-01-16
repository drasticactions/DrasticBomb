using System.Text.Json.Serialization;

namespace DrasticBomb.Models
{
    public class VideosResult
    {
        [JsonPropertyName("api_detail_url")]
        public Uri? ApiDetailUrl { get; set; }

        [JsonPropertyName("associations")]
        public object[]? Associations { get; set; }

        [JsonPropertyName("deck")]
        public string? Deck { get; set; }

        [JsonPropertyName("embed_player")]
        public Uri? EmbedPlayer { get; set; }

        [JsonPropertyName("guid")]
        public string? Guid { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("length_seconds")]
        public long LengthSeconds { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("premium")]
        public bool Premium { get; set; }

        [JsonPropertyName("publish_date")]
        public DateTimeOffset PublishDate { get; set; }

        [JsonPropertyName("site_detail_url")]
        public Uri? SiteDetailUrl { get; set; }

        [JsonPropertyName("image")]
        public Image? Image { get; set; }

        [JsonPropertyName("user")]
        public string? User { get; set; }

        [JsonPropertyName("hosts")]
        public string? Hosts { get; set; }

        [JsonPropertyName("crew")]
        public string? Crew { get; set; }

        [JsonPropertyName("video_type")]
        public object? VideoType { get; set; }

        [JsonPropertyName("video_show")]
        public VideoShow? VideoShow { get; set; }

        [JsonPropertyName("saved_time")]
        public string? SavedTime { get; set; }

        [JsonPropertyName("youtube_id")]
        public string? YoutubeId { get; set; }

        [JsonPropertyName("low_url")]
        public Uri? LowUrl { get; set; }

        [JsonPropertyName("high_url")]
        public Uri? HighUrl { get; set; }

        [JsonPropertyName("hd_url")]
        public Uri? HdUrl { get; set; }

        [JsonPropertyName("url")]
        public Uri? Url { get; set; }
    }
}
