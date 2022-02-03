using ASP_NET_Project.Controllers;
using ASP_NET_Project.Data;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace ASP_NET_Project.Tests.Controllers
{
    [TestFixture]
    public class ItemControllerTests
    {
        private readonly ApplicationDbContext _db;

        [Test]
        public void IndexTest()
        {
            // Arrange
            ItemController itemController = new ItemController(_db);

            // Act
            var result = itemController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateTest()
        {
            // Arrange
            ItemController itemController = new ItemController(_db);

            // Act
            var result = itemController.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}