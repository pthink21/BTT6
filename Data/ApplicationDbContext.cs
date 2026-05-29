using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BTT6.Models;

namespace BTT6.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Điện thoại", Description = "Các loại điện thoại di động" },
                new Category { CategoryId = 2, CategoryName = "Laptop", Description = "Các loại máy tính xách tay" },
                new Category { CategoryId = 3, CategoryName = "Phụ kiện", Description = "Phụ kiện điện tử" }
            );

            builder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "iPhone 15", Description = "Apple iPhone 15 128GB", Price = 22990000, ImageUrl = "/images/iphone15.jpg", CategoryId = 1 },
                new Product { ProductId = 2, ProductName = "Samsung Galaxy S24", Description = "Samsung Galaxy S24 256GB", Price = 19990000, ImageUrl = "/images/samsung-s24.jpg", CategoryId = 1 },
                new Product { ProductId = 3, ProductName = "MacBook Air M3", Description = "Apple MacBook Air M3 13 inch", Price = 27990000, ImageUrl = "/images/macbook-air.jpg", CategoryId = 2 },
                new Product { ProductId = 4, ProductName = "Dell XPS 15", Description = "Dell XPS 15 Core i7", Price = 35990000, ImageUrl = "/images/dell-xps.jpg", CategoryId = 2 },
                new Product { ProductId = 5, ProductName = "AirPods Pro 2", Description = "Apple AirPods Pro thế hệ 2", Price = 5990000, ImageUrl = "/images/airpods.jpg", CategoryId = 3 }
            );
        }
    }
}
