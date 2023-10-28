using Microsoft.EntityFrameworkCore;

namespace OOP_6.DAL.Context
{
    public class UserAppContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public UserAppContext(DbContextOptions<UserAppContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public override int SaveChanges()
        {
            SetRegisteredAt();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            SetRegisteredAt();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            SetRegisteredAt();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetRegisteredAt();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetRegisteredAt()
        {
            ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Added && t.Entity is User)
                        .ToArray();

            foreach (var entity in added)
            {
                if (entity.Entity is User user)
                {
                    user.RegisteredAt = DateTime.UtcNow;
                }
            }

        }
    }
}
