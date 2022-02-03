using ASP_NET_Project.Controllers;

using NUnit;
using NUnit.Framework;

using Moq;
using ASP_NET_Project.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Project.Tests.Controllers
{
    [TestFixture]
    public class CarControllerTests
    {
        // mocking a database
        //private readonly Mock<ICarRepository> _mockRepo;
        //private readonly CarController _controller;

        private readonly ApplicationDbContext _db;

        [Test]
        public void IndexTest()
        {
            // Arrange
            CarController carController = new CarController(_db);
            //_mockRepo = new Mock<ICarRepository>();
            //_controller = new CarController(_mockRepo.Object);

            // Act
            var result = carController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateTest()
        {
            // Arrange
            CarController carController = new CarController(_db);
            //_mockRepo = new Mock<ICarRepository>();
            //_controller = new CarController(_mockRepo.Object);

            // Act
            var result = carController.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void DeleteTest()
        {
            //TODO:

            // Arrange
            CarController carController = new CarController(_db);
            //_mockRepo = new Mock<ICarRepository>();
            //_controller = new CarController(_mockRepo.Object);

            // Act
            var id = 2;
            var result = carController.Delete(id);

            // Assert
            //Assert.IsNotNull(result);
        }

        [Test]
        public void DeletePostTest()
        {
            //TODO:

            // Arrange
            CarController carController = new CarController(_db);
            //_mockRepo = new Mock<ICarRepository>();
            //_controller = new CarController(_mockRepo.Object);

            // Act
            var id = 2;
            var result = carController.DeletePost(id);

            // Assert
            //Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateTest()
        {
            //TODO:

            // Arrange
            CarController carController = new CarController(_db);
            //_mockRepo = new Mock<ICarRepository>();
            //_controller = new CarController(_mockRepo.Object);

            // Act
            var id = 2;
            var result = carController.Update(id);

            // Assert
            //Assert.IsNotNull(result);
        }

    }
}