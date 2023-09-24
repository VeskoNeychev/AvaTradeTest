using System.Text.Json.Serialization;

namespace Database.Entities
{
    public class Bulletin
    {
        public Guid Id { get; set; }

        public int Count { get; set; }

        public string NextUrl { get; set; }

        public string RequestId { get; set; }

        public IEnumerable<News> News { get; set; }

        public string Status { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
