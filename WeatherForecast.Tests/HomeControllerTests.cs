using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WeatherForcast.Controllers;
using WeatherForcast.Core.DTO;

namespace WeatherForecast.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        private readonly FakeWeatherAPI _api;
        private readonly FakeFilterDisplay _filter;

        public HomeControllerTests()
        {
            _api = new FakeWeatherAPI();
            _filter = new FakeFilterDisplay();
        }

        [TestMethod]
        public void API_Results_Returned()
        {
            var controller = new HomeController(_api, _filter);

            var response = controller.Index("london").Result as ViewResult;
            var model = response.Model;

            Assert.IsNotNull(response);
            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void API_Returns_Correct_Model()
        {
            var controller = new HomeController(_api, _filter);
            
            var response = controller.Index("london").Result as ViewResult;
            var model = response.Model;

            Assert.IsInstanceOfType(model, typeof(WeatherForecastDisplay));
        }

        [TestMethod]
        public void API_Forecasts_Are_Returned()
        {
            var controller = new HomeController(_api, _filter);

            var response = controller.Index("london").Result as ViewResult;
            var model = response.Model as WeatherForecastDisplay;

            Assert.IsNotNull(response);
            Assert.AreEqual(1, model.HourlyForcast.Count());
        }
    }
}
