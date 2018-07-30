using System;
using LinqPad;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LinqPad.SchoolModel;

namespace TestSDKVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSchoolModel();
            Console.WriteLine("success");
            Console.ReadKey();
        }
        private static void TestLocal()
        {
            int desertSunId;
            using (var db = new LinqContext())
            {
                var startCity = new Club { Name = "Star City Chess Club", City = "New York" };
                var desertSun = new Club { Name = "Desert Sun Chess Club", City = "Phoenix" };
                var palmTree = new Club { Name = "Palm Tree Chess Club", City = "San Diego" };

                db.Clubs.Add(startCity);
                db.Clubs.Add(desertSun);
                db.Clubs.Add(palmTree);
                db.SaveChanges();
                desertSunId = desertSun.ClubId;
            }

            using (var db = new LinqContext())
            {
                Console.WriteLine("\nLocal Collection Behavior");
                Console.WriteLine("===============");
                Console.WriteLine($"\nNumber of Clubs Contained in Local Collection:{db.Clubs.Local.Count}");
                Console.WriteLine("================");
                Console.WriteLine("\nClubs Retrived from Context Object");
                Console.WriteLine("================");
                foreach (var club in db.Clubs.Take(2))
                {
                    Console.WriteLine($"{club.Name} is located in {club.City}");
                }
                Console.WriteLine("\nClubs Contained in Context Local Collection");
                Console.WriteLine("=================");
                foreach (var club in db.Clubs.Local)
                {
                    Console.WriteLine($"{club.Name} is located in {club.City}");
                }

                db.Clubs.Find(desertSunId);
                Console.WriteLine("\nClubs Retrived form Context Object - Revisted");
                Console.WriteLine("===============");
                foreach (var club in db.Clubs)
                {
                    Console.WriteLine($"{club.Name} is located in {club.City}");
                }

                Console.WriteLine("\nClubs Contained in Context Local Collection - Revisted");
                Console.WriteLine("==============");
                foreach (var club in db.Clubs.Local)
                {
                    Console.WriteLine($"{club.Name} is localed in {club.City}");
                }

                var localClubs = db.Clubs.Local;
                var lonesomePintId = -999;
                localClubs.Add(new Club
                {
                    City = "Portland",
                    Name = "Lonesone Pine",
                    ClubId = lonesomePintId
                });

                localClubs.Remove(db.Clubs.Find(desertSunId));
                Console.WriteLine("\nClub Contained in Context Object - After Adding and Deleting");
                Console.WriteLine("=============");
                foreach (var club in db.Clubs)
                {
                    Console.WriteLine($"{club.Name} is located in {club.City} with a Entity State of {db.Entry(club).State}");
                }
                Console.WriteLine("\nClubs Contained in Context Local Collection - After Adding and Deleting");
                Console.WriteLine("=============");
                foreach (var club in localClubs)
                {
                    Console.WriteLine($"{club.Name} is located in {club.City} with a Entity State of {db.Entry(club).State}");
                }
                Console.WriteLine("\nPress <enter> to continue");
                Console.ReadLine();
            }
        }

        private static void TestSchoolModel()
        {
            using (var db = new LinqContext())
            {
                var course = new Course { Title = "Biology 101" };
                var fred = new Instructor { Name = "Fred Jones" };
                var julia = new Instructor { Name = "Julia Canfield" };
                var section1 = new Section { Course = course, Instructor = fred };
                var section2 = new Section { Course = course, Instructor = julia };

                //var jim = new Student { Name = "Jim Roberts" };
                //jim.sections.Add(section1);

                //var jerry = new Student { Name = "Jerry Jones" };
                //jerry.Sections.Add(section2);

                //var susan = new Student { Name = "Susan O'Reilly" };
                //susan.Sections.Add(section1);

                //var cathy = new Student { Name = "Cathy Ryan" };
                //cathy.Sections.Add(section2);

               
                //db.Students.Add(jim);
                //db.Students.Add(jerry);
                //db.Students.Add(cathy);
                //db.Students.Add(susan);
                //db.SaveChanges();
            }
        }
    }
}
