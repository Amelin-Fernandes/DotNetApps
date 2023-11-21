using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDal
{
    //Domain Classes
    // keep functions separate and class separate always in business logic layer
    //Not mapped means we don't want to create a column in the database
    //concurrency check: you want to force a foreign key
    #region Inheritance
    public class Parent {
        [Key] //known as decorator, attribute, data annotation
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParentKey { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        
    }
    public class Child : Parent { //is a is taken as 1:1 relationship in inheritance
        [NotMapped]
        public int ChildId { get; set; }
        public DateTime BirthDate { get; set; }
        [Range(10, 110)]
        public int Age { get; set; }
    }
    public class Child2 : Parent
    {
        public string Hobbies { get; set; }
    }
    #endregion Inheritance

    #region One2One and One2Many
    public class One {
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
    }
    public class ToOne {
        [Key]
        public int Id { get; set; }
        public One RelatedToOne { get; set; }
    }
    public class ToMany1 {
        [Key]
        public int Id { get; set; }
        public List<One> TooManyOnes { get; set; }
    }

    #endregion One2One and One2Many

    #region Many2Many
    public class Many
    {
        [Key]
        public int Id { get; set; }
        public List<ToMany2> ToMany2s { get; set; }
    }
    public class ToMany2 {
        [Key]
        public int Id { get; set; }
        public List<Many> Manys { get; set; }
    }
    #endregion Many2Many

    //Mapping Layer
    //DbContext is our mapper given by mapper class
    public class TestDbContext : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Child2> Children2 { get; set; }
        public DbSet<One> Ones { get; set; }
        public DbSet<ToOne> ToOnes { get; set; } //List<> ofparent
        public DbSet<ToMany1> ToMany1s { get; set; }
        public DbSet<Many> Manys { get; set; }
        public DbSet<ToMany2> ToMany2s { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //add @ for paths and this is configuration number 2
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestDb;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Using Fluent API
            modelBuilder.Entity<Parent>().Property(p => p.ParentKey).UseIdentityColumn();
            modelBuilder.Entity<Parent>().HasOne<Child>();
            modelBuilder.Entity<Parent>().HasMany<Many>();
        }
    }
}