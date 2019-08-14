using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvcSecond.Models
{
    public class SalesWebMvcSecondContext : DbContext
    {
        public SalesWebMvcSecondContext (DbContextOptions<SalesWebMvcSecondContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvcSecond.Models.Department> Department { get; set; }
    }
}
