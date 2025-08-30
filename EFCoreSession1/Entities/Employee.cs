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


    internal class Employee
    {

        public string EmpId {  get; set; }
        public string Name {  get; set; }
        public string Age {  get; set; }
        public string Email {  get; set; }
        public string Salary {  get; set; }
        public DateTime DateOfCreation { get; set; }




    }

}
