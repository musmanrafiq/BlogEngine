using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBlog.Data.Entities;

namespace UBlog.Data.DummyData
{
    public static class DummyDataProvider
    {
       public static IEnumerable<BlogPost> GetBlogPosts()
        {
            var posts = new List<BlogPost> {
                new BlogPost("Blog Title One","Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac purus nec lorem vestibulum sodales non vitae enim. Aenean mollis dictum felis. Duis mollis scelerisque mi eget condimentum. Fusce efficitur malesuada feugiat. Etiam lobortis bibendum est, quis ultrices neque feugiat ac. Nunc laoreet tortor quis arcu aliquam faucibus. Praesent eget ligula at ipsum convallis rhoncus a eu quam. Vestibulum metus elit, fermentum nec auctor sit amet, placerat vel mauris. Morbi in ex ut mi varius elementum. Morbi porttitor leo nec elementum sodales.","Waqas"),
                new BlogPost("Blog Title Two","Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac purus nec lorem vestibulum sodales non vitae enim. Aenean mollis dictum felis. Duis mollis scelerisque mi eget condimentum. Fusce efficitur malesuada feugiat. Etiam lobortis bibendum est, quis ultrices neque feugiat ac. Nunc laoreet tortor quis arcu aliquam faucibus. Praesent eget ligula at ipsum convallis rhoncus a eu quam. Vestibulum metus elit, fermentum nec auctor sit amet, placerat vel mauris. Morbi in ex ut mi varius elementum. Morbi porttitor leo nec elementum sodales.","Waqas"),
                new BlogPost("Blog Title Three","Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac purus nec lorem vestibulum sodales non vitae enim. Aenean mollis dictum felis. Duis mollis scelerisque mi eget condimentum. Fusce efficitur malesuada feugiat. Etiam lobortis bibendum est, quis ultrices neque feugiat ac. Nunc laoreet tortor quis arcu aliquam faucibus. Praesent eget ligula at ipsum convallis rhoncus a eu quam. Vestibulum metus elit, fermentum nec auctor sit amet, placerat vel mauris. Morbi in ex ut mi varius elementum. Morbi porttitor leo nec elementum sodales.","Waqas"),
                new BlogPost("Blog Title Four","Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac purus nec lorem vestibulum sodales non vitae enim. Aenean mollis dictum felis. Duis mollis scelerisque mi eget condimentum. Fusce efficitur malesuada feugiat. Etiam lobortis bibendum est, quis ultrices neque feugiat ac. Nunc laoreet tortor quis arcu aliquam faucibus. Praesent eget ligula at ipsum convallis rhoncus a eu quam. Vestibulum metus elit, fermentum nec auctor sit amet, placerat vel mauris. Morbi in ex ut mi varius elementum. Morbi porttitor leo nec elementum sodales.","Waqas"),
                new BlogPost("Blog Title Five","Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac purus nec lorem vestibulum sodales non vitae enim. Aenean mollis dictum felis. Duis mollis scelerisque mi eget condimentum. Fusce efficitur malesuada feugiat. Etiam lobortis bibendum est, quis ultrices neque feugiat ac. Nunc laoreet tortor quis arcu aliquam faucibus. Praesent eget ligula at ipsum convallis rhoncus a eu quam. Vestibulum metus elit, fermentum nec auctor sit amet, placerat vel mauris. Morbi in ex ut mi varius elementum. Morbi porttitor leo nec elementum sodales.","Waqas"),
                new BlogPost("Blog Title Six","Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac purus nec lorem vestibulum sodales non vitae enim. Aenean mollis dictum felis. Duis mollis scelerisque mi eget condimentum. Fusce efficitur malesuada feugiat. Etiam lobortis bibendum est, quis ultrices neque feugiat ac. Nunc laoreet tortor quis arcu aliquam faucibus. Praesent eget ligula at ipsum convallis rhoncus a eu quam. Vestibulum metus elit, fermentum nec auctor sit amet, placerat vel mauris. Morbi in ex ut mi varius elementum. Morbi porttitor leo nec elementum sodales.","Waqas"),
                new BlogPost("Blog Title Seven","Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac purus nec lorem vestibulum sodales non vitae enim. Aenean mollis dictum felis. Duis mollis scelerisque mi eget condimentum. Fusce efficitur malesuada feugiat. Etiam lobortis bibendum est, quis ultrices neque feugiat ac. Nunc laoreet tortor quis arcu aliquam faucibus. Praesent eget ligula at ipsum convallis rhoncus a eu quam. Vestibulum metus elit, fermentum nec auctor sit amet, placerat vel mauris. Morbi in ex ut mi varius elementum. Morbi porttitor leo nec elementum sodales.","Waqas"),
                new BlogPost("Blog Title Eight","Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac purus nec lorem vestibulum sodales non vitae enim. Aenean mollis dictum felis. Duis mollis scelerisque mi eget condimentum. Fusce efficitur malesuada feugiat. Etiam lobortis bibendum est, quis ultrices neque feugiat ac. Nunc laoreet tortor quis arcu aliquam faucibus. Praesent eget ligula at ipsum convallis rhoncus a eu quam. Vestibulum metus elit, fermentum nec auctor sit amet, placerat vel mauris. Morbi in ex ut mi varius elementum. Morbi porttitor leo nec elementum sodales.","Waqas")
            };
            return posts;
        }
    }
}
