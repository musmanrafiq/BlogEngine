using Microsoft.AspNetCore.Mvc;

namespace BlogEngine.Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
