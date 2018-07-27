using System;
using LinqPad;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TestSDKVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LinqContext())
            {
                var query = from blog in db.Blogs
                            join post in db.Posts
                            on blog.Id equals post.BlogId
                            into posts
                            where posts.Count() > 0
                            select new { blog, posts };
                query.ForEachAsync(item => item.blog.ToString());
                foreach (var item in query)
                {
                    Console.WriteLine(item.blog.ToString());
                }

                //var posts = db.Posts.Include(p => p.Blog).ToList();
                //foreach (var blog in blogs)
                //{
                //    Console.WriteLine($" ---{blog.Title}--- ");
                //    if (blog.Posts!=null)
                //    {
                //        foreach (var post in blog.Posts)
                //        {
                //            Console.WriteLine(post.Description);
                //        }
                //    }
                //}
            }

            Console.WriteLine("success");
            Console.ReadKey();
        }
    }
}
