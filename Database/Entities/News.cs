using System.Text.Json.Serialization;

namespace Database.Entities
{
    public class News
    {
        public Guid Id { get; set; }

        public string AmpUrl { get; set; }

        public string ArticleUrl { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string NewsId { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<string> Keywords { get; set; }

        public Guid BulletinId { get; set; }

        public Bulletin Bulletin { get; set; }

        public DateTime PublishedUtc { get; set; }

        public Guid PublisherId { get; set; }

        public Publisher Publisher { get; set; }

        public ICollection<string> Tickers { get; set; }

        public string Title { get; set; }
    }
}
