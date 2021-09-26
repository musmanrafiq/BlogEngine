using BlogEngine.Business.Interfaces.Entities;
using BlogEngine.Business.Models;
using BlogEngine.Website.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace BlogEngine.Website.Tests.Controller.Tests
{
    public class HomeControllerTests
    {
        private HomeController controller;


        [Fact]
        public async Task Index_ReturnsViewResult_When_Succeeded()
        {
            //Arrange
            SetupHomeController();

            //Act
            var result = await controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Index_ReturnsPosts_When_Succeeded()
        {
            // Arrange
            SetupHomeController();

            // Act
            var result = await controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsType<List<PostModel>>(viewResult.ViewData.Model);
        }


        #region private methods

        private void SetupHomeController()
        {
            var mockPostService = new Mock<IPostService>();
            var mockPromptService = new Mock<IPromptService>();
            mockPostService.Setup(s => s.GetAll()).Returns(GetList());
            mockPromptService.Setup(prmpt => prmpt.GetAll()).Returns(GetPromptsList());

            controller = new HomeController(mockPostService.Object, mockPromptService.Object);
        }

        // test posts list
        private async Task<List<PostModel>> GetList()
        {
            var postModels = new List<PostModel> { new PostModel { }, new PostModel { } };
            return postModels;
        }

        // test prompts list
        private async Task<List<PromptModel>> GetPromptsList()
        {
            var promptModels = new List<PromptModel> { new PromptModel { }, new PromptModel { } };
            return promptModels;
        }
        #endregion
    }
}
