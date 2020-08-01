using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace College.Models
{
    public class CollegeContext : DbContext
    {
        public CollegeContext(DbContextOptions options) : base(options)
        {
        }
    }
}
