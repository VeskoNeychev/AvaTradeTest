using Database;
using Database.Entities;
using Job.Models;
using Newtonsoft.Json;

namespace Job.Services
{
    public class NewsJobService
    {
        private readonly AvaTradeContext context;
        private readonly HttpClient client;
        private string newsUrl = $"https://api.polygon.io/v2/reference/news?published_utc.gte={DateTime.Now.AddHours(-1):yyyy-MM-dd HH:mm:ss}&order=asc&apiKey=SomeApiKey";

        public NewsJobService(HttpClient client, AvaTradeContext context)
        {
            this.context = context;
            this.client = client;
        }

        public void HandleLastNews()
        {
            BulletinResponce news;
            do
            {
                news = GetLastNewsFromProvaider(newsUrl);
                newsUrl = news.NextUrl;
                SaveNews(news);
            } while (!string.IsNullOrWhiteSpace(news.NextUrl));
        }

        private BulletinResponce GetLastNewsFromProvaider(string url)
        {
            BulletinResponce result = new();
            HttpResponseMessage httpResponse;
            string responseStr;

            try
            {
                httpResponse = client.GetAsync(url).Result;

                if (httpResponse.IsSuccessStatusCode)
                {
                    responseStr = httpResponse.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<BulletinResponce>(responseStr);
                }
            }
            catch (Exception ex)
            {
                //log exeption itself and throw ex, which the job need to handle further
            }
            finally
            {
                // log responce and newsUrl separetly
            }

            return result;
        }

        private void SaveNews(BulletinResponce news)
        {
            if (!string.IsNullOrWhiteSpace(news.RequestId))
            {
                context.AddAsync(new Bulletin
                {
                    Id = Guid.NewGuid(),
                    // add all needed data
                    // Also, instead of inserting a new row, we might need to re-use existing records.
                    // For instance, if a publisher already exists in the database, we should use its details rather than add a new entry.
                });
                context.SaveChangesAsync();
            }
        }
    }
}
