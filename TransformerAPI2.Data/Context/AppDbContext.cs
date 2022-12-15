using Microsoft.EntityFrameworkCore;
using TransformerAPI2.Entities;

namespace TransformerAPI2.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transformer> Transformers { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}