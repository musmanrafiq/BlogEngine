using BlogEngine.Website.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace BlogEngine.Website.Tests.Controller.Tests
{
    public class HomeControllerTests
    {
        private HomeController controller;

        public HomeControllerTests()
        {
            controller = new HomeController();
        }

        [Fact]
        public void Index_ReturnsViewResult_When_Succeeded()
        {
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }

    }
}
