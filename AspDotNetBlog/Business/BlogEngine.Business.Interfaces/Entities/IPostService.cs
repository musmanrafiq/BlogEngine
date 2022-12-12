using BlogEngine.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogEngine.Business.Interfaces.Entities
{
    public interface IPostService
    {
        public Task<List<PostModel>> GetAll();
        public Task<List<PostModel>> Get(string searchQuery);
        public Task<List<PostModel>> CreatePostAsync(PostModel postRequest);
    }
}
