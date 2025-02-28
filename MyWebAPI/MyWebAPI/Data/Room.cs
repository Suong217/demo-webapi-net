using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebAPI.Data
{

    [Table("Room")]
    public class Room
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        [Range(0, double.MaxValue)]
        public byte Discount { get; set; }
        public Boolean IsActive { get; set; }
    }
}
