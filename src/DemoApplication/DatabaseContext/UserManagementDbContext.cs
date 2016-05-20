using Microsoft.EntityFrameworkCore;
using Numero3.EntityFramework.Demo.DomainModel;

namespace Numero3.EntityFramework.Demo.DatabaseContext
{
    public class UserManagementDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        readonly string connectionString;

        public UserManagementDbContext()
        {
            connectionString = "Server=(localdb)\\mssqllocaldb;Database=DbContextScopeDemo;Trusted_Connection=True;MultipleActiveResultSets=true";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
