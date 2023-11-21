using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabDal
{
    //One Student has many courses
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public int StudentName { get; set; }
    }
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        public List<Student> Students { get; set; }
    }

    public class ManyStudent
    {
        [Key]
        public int CourseId { get; set; }
        public List<Courses> ManyStudents { get; set; }
    }

    public class Company
    {
        [Key]
        public int Id { get; set; }
        public Student RelatedToStudent { get; set; }
    }



    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<ManyStudent> ManyStudents { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=StudentDb;Trusted_Connection=true");
        }

        

    }
}