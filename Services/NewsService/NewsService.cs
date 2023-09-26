using Database;
using Microsoft.EntityFrameworkCore;
using Services.Models;

namespace Services.NewsService
{
    public class NewsService : INewsService
    {
        private readonly AvaTradeContext context;

        public NewsService(AvaTradeContext context)
        {
            this.context = context;
        }

        // Get All news, no filters. I would recoment to return news from last week/month 
        public async Task<List<News>> GetAllNewsAsync()
        {
            var news = await context.News
                    .Include(n => n.Publisher)
                    .ToListAsync();

            return news.Select(x => new News
            {
                Author = x.Author,
                // all needed info
            }).ToList();
        }

        public async Task<List<News>> GetAllNewsAsync(int fromLastNDays)
        {
            DateTime newsFromDate = DateTime.Now.AddDays(-fromLastNDays);

            var news = await context.News
                    .Where(n => n.PublishedUtc >= newsFromDate)
                    .Include(n => n.Publisher)
                    .ToListAsync();

            return news.Select(x => new News
            {
                Author = x.Author,
                // all needed info
            }).ToList();
        }

        // ..... Adding all needed services
        // subscribtion for news can be done by user prefered publisher, autor ....
        // not very clear what subscriptions is needed. Define the different types of news subscriptions available,
        // such as email, push notifications, live updates, or any other relevant methods.

    }
}
