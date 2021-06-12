using BlogEngine.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogEngine.Business.Interfaces.Entities
{
    public interface IPostService
    {
        public Task<List<PostModel>> GetAll();
    }
}
