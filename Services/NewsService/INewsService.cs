using Services.Models;

namespace Services.NewsService
{
    public interface INewsService
    {
        Task<List<News>> GetAllNewsAsync();

        Task<List<News>> GetAllNewsAsync(int fromLastNDays);
    }
}
