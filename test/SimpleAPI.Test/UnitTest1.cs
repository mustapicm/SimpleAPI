using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        private readonly ILogger<WeatherForecastController> _logger;

        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnVals()
        {
            var returnValue = controller.Get(1);
            Assert.Equal(20, returnValue.TemperatureC);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
