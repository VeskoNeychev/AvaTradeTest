namespace Services.Models
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

        public List<string> Keywords { get; set; }

        public DateTime PublishedUtc { get; set; }

        public Publisher Publisher { get; set; }

        public List<string> Tickers { get; set; }

        public string Title { get; set; }
    }
}
