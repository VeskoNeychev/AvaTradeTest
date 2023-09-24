using Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Database
{
    public class AvaTradeContext : DbContext
    {
        public AvaTradeContext(DbContextOptions<AvaTradeContext> options)
            : base(options)
        {
            
        }

        public DbSet<Bulletin> Bulletins { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<News> News { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ChangeTracker.DetectChanges();

            //we can add what ever logic is needed heere

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
