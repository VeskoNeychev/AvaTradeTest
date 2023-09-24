using System.Text.Json.Serialization;

namespace API.Models
{
    public class Publisher
    {
        public Guid Id { get; set; }

        public string FaviconUrl { get; set; }

        public string HomepageUrl { get; set; }

        public string LogoUrl { get; set; }

        public string Name { get; set; }
    }
}
