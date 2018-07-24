using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BLoggingContext())
            {
                db.Blogs.Add(new Blog
                {
                    Url = "http://blogs.msdn.com"
                });
                var count = db.SaveChanges();
                Console.WriteLine($"{count} records saved to database");

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine($" - {blog.Url}");
                }
            }
        }
    }
}
