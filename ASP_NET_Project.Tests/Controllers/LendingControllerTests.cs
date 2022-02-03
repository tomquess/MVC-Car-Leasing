using ASP_NET_Project.Controllers;
using ASP_NET_Project.Data;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace ASP_NET_Project.Tests.Controllers
{
    [TestFixture]
    public class LendingControllerTests
    {
        private readonly ApplicationDbContext _db;

        [Test]
        public void IndexTest()
        {
            // Arrange
            LendingController lendingController = new LendingController(_db);

            // Act
            var result = lendingController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateTest()
        {
            // Arrange
            LendingController lendingController = new LendingController(_db);

            // Act
            var result = lendingController.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateErrorTest()
        {
            // Arrange
            LendingController lendingController = new LendingController(_db);

            // Act
            var result = lendingController.CreateError() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void DeleteTest()
        {
            // Arrange
            LendingController lendingController = new LendingController(_db);

            // Act
            var id = 2;
            var result = lendingController.Delete(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void DeletePostTest()
        {
            // Arrange
            LendingController lendingController = new LendingController(_db);

            // Act
            var id = 2;
            var result = lendingController.DeletePost(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateTest()
        {
            // Arrange
            LendingController lendingController = new LendingController(_db);

            // Act
            var id = 2;
            var result = lendingController.Update(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}