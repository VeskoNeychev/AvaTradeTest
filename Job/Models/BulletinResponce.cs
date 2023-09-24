using System.Text.Json.Serialization;

namespace Job.Models
{
    public class BulletinResponce
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next_url")]
        public string NextUrl { get; set; }

        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        [JsonPropertyName("results")]
        public IEnumerable<NewsResponce> Results { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}



