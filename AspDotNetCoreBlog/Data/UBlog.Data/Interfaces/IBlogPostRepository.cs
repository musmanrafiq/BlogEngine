using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBlog.Data.Entities;

namespace UBlog.Data.Interfaces
{
    public interface IBlogPostRepository
    {
        IEnumerable<BlogPost> GetAll();
    }
}
