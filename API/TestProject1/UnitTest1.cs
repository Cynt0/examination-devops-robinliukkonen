using API;
using API.Controllers;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly WeatherForecastController _weatherForecastController;
        private readonly ILogger<WeatherForecastController> _logger;
        public UnitTest1()
        {
            _weatherForecastController = new WeatherForecastController(_logger);
        }
        [Fact]
        public async void Test1()
        {
            var respone = _weatherForecastController.Get();
            Assert.NotNull(respone);
        }
    }
}