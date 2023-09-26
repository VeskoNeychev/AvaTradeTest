using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.NewsService;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // we can create a custom authorization attribute, to match company requarements. 
    public class NewsController : ControllerBase
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        [HttpGet]
        //[CustomAutorization]
        public async Task<IActionResult> GetAllNews()
            => Ok(await newsService.GetAllNewsAsync());


        /// <summary>
        /// Getting last news since n days
        /// </summary>
        /// <param name="fromLastNDays"></param>
        /// <returns></returns>
        [HttpGet]
        //[CustomAutorization]
        public async Task<IActionResult> GetAllNews(int fromLastNDays)
            => Ok(await newsService.GetAllNewsAsync(fromLastNDays));

        //[HttpGet]
        //No aurorization, so it's public
        //public IActionResult GetNewsForTopInstruments()
        //    =>Ok(GetAllNews());
    }
}
