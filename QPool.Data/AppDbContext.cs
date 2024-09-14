using Microsoft.EntityFrameworkCore;
using QPool.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPool.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Question> Questions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Technology>()
                .HasMany(t => t.Questions)
                .WithOne(q => q.Technology)
                .HasForeignKey(q => q.TechnologyID);
        }
    }

}
