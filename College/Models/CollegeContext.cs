using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace College.Models
{
    public class CollegeContext : DbContext
    {
        public CollegeContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=College;Data Source=(LocalDb)\MSSQLLocalDB;");
            }
        }
    }
}
