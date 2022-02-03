using ASP_NET_Project.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NUnit.Framework;


namespace ASP_NET_Project.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        // inappriopriate way of stubbing
        private readonly ILogger<HomeController> _logger;

        [Test]
        public void IndexTest()
        {
            // Arrange
            HomeController homeController = new HomeController(_logger);
            // Act
            var result = homeController.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void PrivacyTest()
        {
            // Arrange
            HomeController homeController = new HomeController(_logger);
            // Act
            var result = homeController.Privacy() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void ErrorTest()
        {
            // Arrange
            //HomeController homeController = new HomeController(_logger);
            // Act
            //var result = homeController.Error() as ViewResult;
            // Assert
            //Assert.Pass();
        }
    }
}