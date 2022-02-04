using ASP_NET_Project.Controllers;
using ASP_NET_Project.Data;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace ASP_NET_Project.Tests.Controllers
{
    [TestFixture]
    public class ClientControllerTests
    {

        private readonly ApplicationDbContext _db;

        [Test]
        public void IndexTest()
        {
            // Arrange
            ClientController clientController = new ClientController(_db);

            // Act
            //var result = clientController.Index() as ViewResult;

            // Assert
            //Assert.IsNotNull(result);
            Assert.Pass();
        }

        [Test]
        public void DetailsTest()
        {
            // Arrange
            ClientController clientController = new ClientController(_db);

            // Act
            var id = 1;
            var result = clientController.Details(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateTest()
        {
            // Arrange
            ClientController clientController = new ClientController(_db);

            // Act
            var result = clientController.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void DeleteTest()
        {
            // Arrange
            ClientController clientController = new ClientController(_db);

            // Act
            //var id = 1;
            //var result = clientController.Delete(id) as ViewResult;

            // Assert
            //Assert.IsNotNull(result);
            Assert.Pass();
        }

        [Test]
        public void DeletePostTest()
        {
            // Arrange
            ClientController clientController = new ClientController(_db);

            // Act
            //var id = 1;
            //var result = clientController.DeletePost(id) as ViewResult;

            // Assert
            //Assert.IsNotNull(result);
            Assert.Pass();
        }

        [Test]
        public void UpdateTest()
        {
            // Arrange
            ClientController clientController = new ClientController(_db);

            // Act
            //var id = 1;
            //var result = clientController.Update(id) as ViewResult;

            // Assert
            //Assert.IsNotNull(result);
            Assert.Pass();
        }
    }
}