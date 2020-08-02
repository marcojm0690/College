using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace College.Models
{
    public class CollegeContext : DbContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Notes> Notes { get; set; }

        public CollegeContext(DbContextOptions options) : base(options)
        {
        }

    }
}
