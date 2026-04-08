using FinTrack.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Api.Data
{
    public class FinTrackDbContext : DbContext
    {
        public FinTrackDbContext(DbContextOptions<FinTrackDbContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>()
                .Property(a => a.Balance)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Transaction>()
                .Property(t => t.Amount)
                .HasPrecision(18, 2);
        }
    }
}