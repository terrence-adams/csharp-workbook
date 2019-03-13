using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class ToDoDBContext : DbContext
    {

        public ToDoDBContext(DbContextOptions<ToDoDBContext> options) : base(options)
        {

        }

        public DbSet<ToDo> ToDOS { get; set; }


    }
}
