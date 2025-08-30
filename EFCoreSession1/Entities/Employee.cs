using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSession1.Entities
{
    //internal class Employee
    //{

    //    //Entity
    //    //poco : plain old clr object  , hasn't functionalities  
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Age  { get; set; }
    //    public double Salary { get; set; }
    //    public string Email { get; set; }

    //    public DateTime DateOfCreation { get; set; }




    //}

    //[Table("ehab",Schema ="dbo")]
    //internal class Employee
    //{


    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }
    //    [Required]
    //    [Column("EmpName",TypeName ="varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50,MinimumLength =10)]
    //    public string Name { get; set; }
    //    [Range(18,60)] // validation outside db 

    //    public int Age { get; set; }

    //    [Column(TypeName ="money")]
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }
    //    [EmailAddress]
    //    public string Email { get; set; }

    //    [NotMapped]
    //    public DateTime DateOfCreation { get; set; }


    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public string PhoneNumber { set; get; }




    //}


    //internal class Employee
    //{

    //    public string EmpId {  get; set; }
    //    public string Name {  get; set; }
    //    public string Age {  get; set; }
    //    public string Email {  get; set; }
    //    public string Salary {  get; set; }
    //    public DateTime DateOfCreation { get; set; }




    //}



















    // V04
    // EF Core Supports 4 Ways For Mapping Classes in Database: [Table, View, Function]
    // 1. By Convention [Default Behavior]
    // 2. Data Annotation [Set of Attributes]
    // Entity
    // POCO: Plain Old CLR Object

    // 3. Fluent API 
    // 4. Class Configuration - Recommended


    #region 04 Ways Of Mapping (By Convension)
    /*
    internal class Employee // Table
    {
        public int Id { get; set; } // Public Number Property Named Id or <ClassName>Id(EmployeeId) -> Primary Key -> Identity
        public string Name { get; set; } // Reference Type : Required [Not Allow Null] - Nvarchar(max)
        public int? Age { get; set; } // Value Type : int[Age] - Optional [Allow Null]
        public decimal Salary { get; set; } // Value Type : float[Salary] - Required
        public string? Email { get; set; } // nvarchar(max) - Optional [Allow Null]
        public DateTime DateOfCreation { get; set; } // datetime2 - Required

    }
    */
    #endregion

    #region 05  Ways Of Mapping (Data Annotation)
    /*
    //[Table("Hamda", Schema = "dbo")]
    class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; }


        [Required]
        [Column("EmpName", TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public string Name { get; set; }


        [Range(20, 60)]
        public int? Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string phoneNumber { get; set; }

        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        [NotMapped]
        public double TotalSalary { get; set; }

        public string Password { get; set; }

    }
    */
    #endregion


    #region 08 FluentApi

    class Employee
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfCreation { get; set; }


    }

    #endregion

}
