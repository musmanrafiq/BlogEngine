using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBlog.Data.Entities;
using UBlog.Data.Interfaces;

namespace UBlog.Data.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly IEnumerable<BlogPost> _posts;

        public BlogPostRepository(IEnumerable<BlogPost> posts)
        {
            _posts = posts;
        }
        public IEnumerable<BlogPost> GetAll()
        {
            return _posts;
        }
    }
}
