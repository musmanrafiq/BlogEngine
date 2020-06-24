using BlogEngine.Business.Models;
using System.Collections.Generic;

namespace BlogEngine.Business.Interfaces.entity
{
    public interface IPostService
    {
        public List<PostModel> GetAll();
    }
}
