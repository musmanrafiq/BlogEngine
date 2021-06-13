using BlogEngine.Business.Interfaces.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogEngine.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        private readonly IPromptService _promptService;

        public HomeController(IPostService postService, IPromptService promptService)
        {
            _postService = postService;
            _promptService = promptService;
        }

        public async Task<IActionResult> Index()
        {
            var prompts = await _promptService.GetAll();
            var allPosts = await _postService.GetAll();
            return View(allPosts);
        }
    }
}
