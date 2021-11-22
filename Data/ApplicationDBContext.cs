using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Models;
namespace MVCMovie.Data
{
      public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMovie.Models.Movie> Movie { get; set; }

        public DbSet<MVCMovie.Models.Person> Person { get; set; }

        public DbSet<MVCMovie.Models.Student> Student { get; set; }

        public DbSet<MVCMovie.Models.Employee> Employee { get; set; }

        public DbSet<MVCMovie.Models.Product> Product { get; set; }
         public DbSet<MVCMovie.Models.Young> Youngs { get; set; }
         public DbSet<MVCMovie.Models.Category> Category { get; set; }
         public DbSet<MVCMovie.Models.LHD> LHD { get; set; }
         public DbSet<MVCMovie.Models.HD> HD { get; set; }
         public DbSet<MVCMovie.Models.NLN> NLN_1 { get; set; }
         public DbSet<MVCMovie.Models.DT> DT { get; set; }
         
    }

}

  