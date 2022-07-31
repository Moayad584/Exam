using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoayadPracticalExam.Models.Entities
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ProductsCategories")]
        public string CreatedBy { get; set; }

        [Required]
        [ForeignKey("ProductsCategories")]
        public DateTime CreatedAt { get; set; }

        [MaxLength(50)]
        [ForeignKey("ProductsCategories")]
        public string Name { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        public int Price { get; set; }


        public float DiscountPercentage { get; set; }

        public ProductsCategories ProductsCategories { get; set; }

    }
}
