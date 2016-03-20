using Microsoft.Data.Entity;
using Numero3.EntityFramework.Demo.DomainModel;

namespace Numero3.EntityFramework.Demo.DatabaseContext
{
    public class UserManagementDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        readonly string connectionString;

        public UserManagementDbContext()
        {
            connectionString = "Server=localhost;Database=DbContextScopeDemo;Trusted_Connection=true;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
