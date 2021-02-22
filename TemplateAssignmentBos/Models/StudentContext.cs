using Microsoft.EntityFrameworkCore;

namespace TemplateAssignmentBos.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1, FirstName = "Mike", LastName = "Derry", Grade = 49
                },
                new Student
                {
                    StudentId = 2, FirstName = "Sharon", LastName = "Stone", Grade = 59
                },
                new Student
                {
                    StudentId = 3, FirstName = "Sturm", LastName = "Thurman", Grade = 69
                },
                new Student
                {
                    StudentId = 4, FirstName = "Bronze", LastName = "Erat", Grade = 79
                }
            );
        }
    }
}