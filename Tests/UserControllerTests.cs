
using System.Web.Mvc;
using CRUD_application_2.Controllers;
using CRUD_application_2.Models;
using System.Collections.Generic;
using NUnit.Framework;
namespace CRUD_application_2.Tests
{

    [TestFixture]
    public class UserControllerTests
    {
        private UserController _userController;
        private List<User> _users;

        [SetUp]
        public void Setup()
        {
            _users = new List<User>
        {
            new User { Id = 1, Name = "Test User 1", Email = "test1@example.com" },
            new User { Id = 2, Name = "Test User 2", Email = "test2@example.com" }
        };

            UserController.userlist = _users;
            _userController = new UserController();
        }

        [Test]
        public void Index_ReturnsViewResult()
        {
            // Arrange

            // Act
            var result = _userController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void Create_ReturnsViewResult()
        {
            // Arrange

            // Act
            var result = _userController.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void Edit_ReturnsViewResult()
        {
            // Arrange
            int id = 1;

            // Act
            var result = _userController.Edit(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void Delete_ReturnsViewResult()
        {
            // Arrange
            int id = 1;

            // Act
            var result = _userController.Delete(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
         
}