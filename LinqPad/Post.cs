using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPad
{
    public class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Description { get; set; }
        public virtual Blog Blog { get; set; }

        public override string ToString()
        {
            return $"--{Id}--{BlogId} -- {Description}--{Blog.Title}";
        }
    }
}
