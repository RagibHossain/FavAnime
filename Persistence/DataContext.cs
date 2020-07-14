using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<AnimeReview> AnimeReviews {get; set;}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }
    }
}
