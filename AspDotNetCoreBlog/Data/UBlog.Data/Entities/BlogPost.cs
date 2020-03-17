using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBlog.Data.Entities
{
    public class BlogPost
    {
        public BlogPost(string title,string content,string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        public string Content { get; set; }

        public string Author { get; set; }
    }
}
