using BlogEngine.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogEngine.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            _postRepository.Add(new Data.Model.Entities.Post { Title = "Test title" });
            await _unitOfWork.SaveChangesAsync();

            var allPosts = await _postRepository.GetAsync();
            return View();
        }
    }
}
