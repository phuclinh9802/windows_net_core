using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practice.Models;

namespace practice.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions options) : base(options) { }

     

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Register> Users { get; set; }
        public DbSet<News> NewsAPI { get; set; }
    }
}
