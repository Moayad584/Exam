using Microsoft.EntityFrameworkCore;
using MoayadPracticalExam.Models.Entities;

namespace MoayadPracticalExam.Models
{
    public class ProductDBController : DbContext

    {
        public ProductDBController( DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductsCategories> ProductsCategories { get; set; }

        public DbSet<ApplicationUsers> ApplicationUsers { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Products> Products { get; set; }


    }
}
