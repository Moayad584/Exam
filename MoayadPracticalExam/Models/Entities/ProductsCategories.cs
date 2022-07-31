using System;
using System.ComponentModel.DataAnnotations;

namespace MoayadPracticalExam.Models.Entities
{
    public class ProductsCategories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public  DateTime CreatedAt { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

    }
}
