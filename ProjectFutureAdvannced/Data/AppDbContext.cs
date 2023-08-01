using Microsoft.EntityFrameworkCore;
using ProjectFutureAdvannced.Extensions;
using ProjectFutureAdvannced.Model;

namespace ProjectFutureAdvannced.Data
    {
    public class AppDbContext:DbContext
        {
        public DbSet<Category> Categories { get; set; }
        public AppDbContext( DbContextOptions<AppDbContext> options ) : base(options)
            {
            }
        protected override void OnModelCreating( ModelBuilder modelBuilder )
            {
            modelBuilder.SetCategory();
            }
        }
    }
