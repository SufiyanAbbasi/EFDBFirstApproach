using EFDBFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFDBFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly NorthwindContext _dbContext;
        private readonly ILogger<WeatherForecastController> _logger;


        public WeatherForecastController(ILogger<WeatherForecastController> logger, NorthwindContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<dynamic> Get()
        {
            return _dbContext.Products.ToList();
        }
    }
}
