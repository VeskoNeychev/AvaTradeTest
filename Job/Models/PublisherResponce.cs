using System.Text.Json.Serialization;

namespace Job.Models
{
    public class PublisherResponce
    {
        [JsonPropertyName("favicon_url")]
        public string FaviconUrl { get; set; }

        [JsonPropertyName("homepage_url")]
        public string HomepageUrl { get; set; }

        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
