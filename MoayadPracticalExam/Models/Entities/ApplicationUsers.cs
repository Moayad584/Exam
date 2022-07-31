using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoayadPracticalExam.Models.Entities
{
    public class ApplicationUsers
    {
        [Key]
        
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        [ForeignKey("ProductsCategories")]
        public string Name { get; set; }
        [Required]
       public string UserName { get; set; }
        [Required]
        public  string PassWord { get; set; }
        [Required]
        public int Type { get; set; }


        public ProductsCategories ProductsCategories { get; set; }


    }
}
