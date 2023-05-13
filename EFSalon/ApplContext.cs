using Microsoft.EntityFrameworkCore;
using EFSalon;

namespace ASPEFSalon
{
        public class ApplContext : DbContext
        {
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Master> Masters { get; set; } = null!;
        public ApplContext(DbContextOptions<ApplContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                    new Client { Id = 1, Name = "Client1", Surname = "a", Gender = "M" },
                    new Client { Id = 2, Name = "Client2", Surname = "b", Gender = "M" },
                    new Client { Id = 3, Name = "Client3", Surname = "c", Gender = "M" }
            );

            modelBuilder.Entity<Master>().HasData(
                   new Master { Id = 1, Name = "Master1", Surname = "a", Gender = "M" },
                   new Master { Id = 2, Name = "Master2", Surname = "b", Gender = "M" },
                   new Master { Id = 3, Name = "Master3", Surname = "c", Gender = "M" }
           );
        }
    }
}
