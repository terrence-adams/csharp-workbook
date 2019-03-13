using Microsoft.EntityFrameworkCore;
using System;

namespace EF
{
    class Program
    {
        public static object CreateDate { get; private set; }
        public static string Content { get; private set; }

        static void Main(string[] args)
        {
            bool created;
            string connectionStr = "Server=(localdb)\\MSSQLLocalDB;Database= BlogDB;Trusted_Connection=True";
            DbContextOptionsBuilder<BlogDbContext> builder = new DbContextOptionsBuilder<BlogDbContext>();
            builder.UseSqlServer(connectionStr);
            DbContextOptions<BlogDbContext> options = builder.Options;
            BlogDbContext context = new BlogDbContext(options);
            created = context.Database.EnsureCreated();
            //context.Database.Migrate();
            Console.WriteLine("Database Created {0}", created);
            Console.ReadLine();
            Blog firstEntry = new Blog
            {
                Title = "Thirst",
                CreateDate = DateTime.Now,
                Content = "Peter Piper"

            };
            Tag firstTag = new Tag
            {
                Data = "Words are Important"
            };

            context.Blogs.Add(firstEntry);
            context.SaveChanges();
            context.Tags.Add(firstTag);
            context.SaveChanges();


            foreach (var b in context.Blogs)
            {
                Console.WriteLine(b.ID + " ->" + b.Title);

            }

            foreach (var t in context.Tags)
            {
                Console.WriteLine(t.Data);
            }

            Console.ReadLine();

        }
    }
}
