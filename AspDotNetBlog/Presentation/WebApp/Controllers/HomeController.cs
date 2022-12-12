using BlogEngine.Business.Interfaces.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogEngine.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;

        public HomeController(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<IActionResult> Index()
        {
            // fetched all posts from database
            var allPosts = await _postService.GetAll();
            return View(allPosts);
        }

        public async Task<IActionResult> Search(string query)
        {
            // fetched all posts from database
            var allPosts = await _postService.Get(query);
            return View( nameof(Index), allPosts);
        }
    }
}
