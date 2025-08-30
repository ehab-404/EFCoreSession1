using Microsoft.EntityFrameworkCore;
using Ass_EFC01.Entities;
using Ass_EFC01.Configurations;

namespace Ass_EFC01.Contexts
{
    public class AssEFC01Context : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

        public AssEFC01Context() : base() { } // constructor

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server = PC_2001\\SQLEXPRESS; Database = Ass_EFC01; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Stud_CourseConfiguration());
            modelBuilder.ApplyConfiguration(new Course_InstConfiguration());
        }
    }
}
