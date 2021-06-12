using BlogEngine.Business.Interfaces.Entities;
using BlogEngine.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogEngine.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IPostService postService, IUnitOfWork unitOfWork)
        {
            _postService = postService;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var allPosts = await _postService.GetAll();
            return View(allPosts);
        }
    }
}
