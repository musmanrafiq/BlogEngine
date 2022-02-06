using BlogEngine.Business.Interfaces.Entities;
using BlogEngine.Business.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Threading.Tasks;

namespace BlogEngine.Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostsController : Controller
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<IActionResult> Index()
        {
            var allPosts = await _postService.GetAll();
            return View(allPosts);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.ActionUrl = GetActionUrl();
            var viewModel = new PostModel();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostModel model)
        {

            _ = await _postService.CreatePostAsync(model);
            return Redirect("~/Admin/Posts");
        }

        private string GetActionUrl()
        {
            var request = Request.HttpContext.Request;
            return $"{request.Scheme}://{request.Host}{request.Path}";            
        }
    }
}
