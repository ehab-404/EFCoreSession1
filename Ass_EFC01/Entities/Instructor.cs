using System.ComponentModel.DataAnnotations;

namespace Ass_EFC01.Entities
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public int? Bounus { get; set; }
        public decimal Salary { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public decimal HourRateBouns { get; set; }

        public int Dept_ID { get; set; }
    }
}