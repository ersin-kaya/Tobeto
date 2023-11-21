using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class NorthwindContext : DbContext, IConnectionString
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string serverAddress = IConnectionString.ServerAddress;
            string database = IConnectionString.Database;
            string username = IConnectionString.Username;
            string password = IConnectionString.Password;
            string connectionString = string.Format("Server={0};Database={1};User={2};Password={3};Encrypt=False;", serverAddress, database, username, password);

            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

