using System;
using LinqPad;
using System.Collections.Generic;
using System.Linq;


namespace TestSDKVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic query;
            using (LinqContext db = new LinqContext())
            {
                query = (from DBBlog in db.Blogs.AsQueryable()
                             join DBPost in db.Posts.AsQueryable()
                             on DBBlog.BlogId equals DBPost.BlogId into posts
                             where posts.Count() > 0
                             select new { Blog = DBBlog, Posts = posts }).ToList();                
            }
            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
