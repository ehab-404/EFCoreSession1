using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreSession1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreSession1.Configurations
{
    internal class EmployeeConfigurations:IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> e)
        {
          //  e.HasKey(e => e.EmpId);
            e.HasKey(e => new { e.EmpId,e.Email});
            e.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnName("name")
            .HasColumnType("varchar");
            e.Property(e => e.Age).IsRequired(false);
            e.Property(e => e.Salary).HasColumnType("money");


            //  e.Property(e => e.DateOfCreation).HasDefaultValue(DateTime.Now);
            e.Property(e => e.DateOfCreation).HasDefaultValueSql("GetDate()");




        }

    }
}
