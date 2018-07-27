using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPad
{
    public class Blog
    {
        public int Id { get; set; }
        //public int BlogId { get; set; }
        public string Title { get; set; }
        public virtual List<Post> Posts { get; set; }

        public override string ToString()
        {
            StringBuilder blog = new StringBuilder($"--{Id}--{Title}--\r\n");
            if (Posts != null)
            {
                foreach (var post in Posts)
                {
                    blog.Append($"----{post.Id}--{post.Description}--\r\n");
                }
            }
            return blog.ToString();

        }
    }
}
