using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreSession1.Configurations;
using EFCoreSession1.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSession1.Contexts
{
    internal class AppDbContext:DbContext
    {
        //Microsoft.EntityFrameWorkCoreSqlServer  of version that comaptible with .net version 
        //db context class must inherit from DbContext that represent db session
        //in db context define classes to represent entities 


        //make overriding on OnConfiguring method to build options depend on your db 

        public AppDbContext():base() { }  //chain on ctrl of DbContext ctrl that call OnConfiguring method 

        //so when you create object of context you already start connection with database 




        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            //start using connection string
            optionsBuilder.UseSqlServer("Server=.; DataBase=AppG03; Trusted_Connection=True; TrustServerCertificate=True;"); }




        //to define class like Employee  to represent table Employees : make prop of type of class DbSet of generic type T thatmust be class 

        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> Departments { get; set; }



        protected   override void OnModelCreating(ModelBuilder modelbuilder)
        {
            //modelbuilder.Entity<Employee>().ToView();
            //modelbuilder.Entity<Employee>().HasKey(e => e.Id);


            //modelbuilder.Entity<Employee>
            //    .Property(e => e.Name)
            //    .IsRequired()
            //    .HasMaxLength(50)
            //    .HasColumnName("name")
            //    .HasColumnType("varchar");

            //modelbuilder.Entity<Employee>.Property(e => e.Age).IsRequired("false");
            //modelbuilder.Entity<Employee>.Property(e => e.Salary).HasColumnType("money");


            //modelbuilder.Entity<Employee>.Property(e => e.DateOfCreation).HasDefaultValue(DateTime.Now);
            //modelbuilder.Entity<Employee>.Property(e => e.DateOfCreation).HasDefaultValueSql("GetDate()");


            //modelbuilder.Entity<Employee>(e =>
            //{
            //    e.HasKey(e => e.Id);
            //    e.Property(e => e.Name)
            //    .IsRequired()
            //    .HasMaxLength(50)
            //    .HasColumnName("name")
            //    .HasColumnType("varchar");
            //    e.Property(e => e.Age).IsRequired("false");
            //    e.Property(e => e.Salary).HasColumnType("money");


            //    //  e.Property(e => e.DateOfCreation).HasDefaultValue(DateTime.Now);
            //    e.Property(e => e.DateOfCreation).HasDefaultValueSql("GetDate()");



            //});


            modelbuilder.ApplyConfiguration(new EmployeeConfigurations());


            base.OnModelCreating(modelbuilder);
        }


    }



}
