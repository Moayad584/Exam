using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoayadPracticalExam.Models.Entities
{
    public class CartItem
    {
       [Key]
       public  int Id { get; set; }


        [Required]
        [ForeignKey("ProductsCategories")]
        public string CreatedBy { get; set; }


        [Required]
        [ForeignKey("ProductsCategories")]
        public DateTime CreatedAt { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int Price { get; set; }
        [Required]
        public int TotalPrice { get; set; }

        public ProductsCategories ProductsCategories { get; set; }

    }
}
