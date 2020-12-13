using BlogEngine.Business.Interfaces.entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogEngine.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;

        public HomeController()
        {
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //var postModels = _postService.GetAll();
            return View();
        }
    }
}
