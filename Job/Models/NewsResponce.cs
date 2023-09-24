using System.Text.Json.Serialization;

namespace Job.Models
{
    public class NewsResponce
    {
        [JsonPropertyName("amp_url")]
        public string AmpUrl { get; set; }

        [JsonPropertyName("article_url")]
        public string ArticleUrl { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("keywords")]
        public string[] Keywords { get; set; }

        [JsonPropertyName("published_utc")]
        public DateTime PublishedUtc { get; set; }

        [JsonPropertyName("publisher")]
        public PublisherResponce Publisher { get; set; }

        [JsonPropertyName("tickers")]
        public string[] Tickers { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
