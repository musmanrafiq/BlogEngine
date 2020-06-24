using BlogEngine.Business.Interfaces.entity;
using BlogEngine.Business.Models;
using BlogEngine.Website.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace BlogEngine.Website.Tests.Controller.Tests
{
    public class HomeControllerTests
    {
        private HomeController controller;


        [Fact]
        public void Index_ReturnsViewResult_When_Succeeded()
        {
            //Arrange
            SetupHomeController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_ReturnsPosts_When_Succeeded()
        {
            // Arrange
            SetupHomeController();

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsType<List<PostModel>>(viewResult.ViewData.Model);
        }


        #region private methods

        private void SetupHomeController()
        {
            var mockPostService = new Mock<IPostService>();
            mockPostService.Setup(s => s.GetAll()).Returns(GetList());
            controller = new HomeController(mockPostService.Object);
        }

        // test posts list
        private List<PostModel> GetList()
        {
            var postModels = new List<PostModel> { new PostModel { }, new PostModel { } };
            return postModels;
        }
        #endregion
    }
}
