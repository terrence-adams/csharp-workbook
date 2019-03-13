using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace EF
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {


        }

    }
}
