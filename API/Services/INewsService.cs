using API.Models;

namespace API.Services
{
    public interface INewsService
    {
        Task<List<News>> GetAllNewsAsync();

        Task<List<News>> GetAllNewsAsync(int fromLastNDays);
    }
}
