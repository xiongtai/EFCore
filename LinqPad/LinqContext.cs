using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using LinqPad.SchoolModel;

namespace LinqPad
{
    public class LinqContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SectionStudent>().HasKey(s => new { s.SectionId, s.StudentId });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = (localdb)\mssqllocaldb;database = BlogTest;Integrated Security = true;");
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new ConsoleLoggerProvider((category, level) => category == DbLoggerCategory.Database.Command.Name &&
            level == LogLevel.Information, true));
            optionsBuilder.UseLoggerFactory(loggerFactory);
            //optionsBuilder.UseLazyLoadingProxies();
        }



        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Club> Clubs { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<SectionStudent> SectionStudents { get; set; }
    }
}
