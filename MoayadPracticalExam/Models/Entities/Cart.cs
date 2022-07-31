using System.ComponentModel.DataAnnotations;

namespace MoayadPracticalExam.Models.Entities
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

         [Required]
        public int TotalPrice { get; set; }
    }
}
