using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class TobetoCourseAcademyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string serverAddress = IConnectionString.ServerAddress;
            string database = IConnectionString.Database;
            string username = IConnectionString.Username;
            string password = IConnectionString.Password;
            string connectionString = string.Format("Server={0};Database={1};User={2};Password={3};Encrypt=False;", serverAddress, database, username, password);

            optionsBuilder.UseSqlServer(connectionString);

            //optionsBuilder.UseSqlServer("Server=localhost;Database=TobetoCourseAcademy;Trusted_Connection= true;TrustServerCertificate=True");
        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
    }
}
