using System.ComponentModel.DataAnnotations;

namespace Ass_EFC01.Entities
{
    public class Topic
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}