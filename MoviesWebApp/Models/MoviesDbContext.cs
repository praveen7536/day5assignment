using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Models
{
    public class MoviesDbContext: DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {

        }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Review> Reviews { get; set; }


    }
}
