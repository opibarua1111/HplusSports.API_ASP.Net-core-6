using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Active Were 1", },
                new Category { Id = 2, Name = "Active Were 2", },
                new Category { Id = 3, Name = "Active Were 3", },
                new Category { Id = 4, Name = "Active Were 4", } );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId=1, Name= "product 1", IsAvailable=true, Price=100, Sku="sku1",Description= "des1"},
                new Product { Id = 2, CategoryId = 1, Name = "product 2", IsAvailable = true, Price = 100, Sku = "WERT", Description = "des1" },
                new Product { Id = 3, CategoryId = 1, Name = "product 3", IsAvailable = true, Price = 90, Sku = "WFPT", Description = "des1" },
                new Product { Id = 4, CategoryId = 2, Name = "product 4", IsAvailable = true, Price = 130, Sku = "WEIT", Description = "des1" },
                new Product { Id = 5, CategoryId = 2, Name = "product 5", IsAvailable = true, Price = 300, Sku = "WERD", Description = "des1" },
                new Product { Id = 6, CategoryId = 3, Name = "product 6", IsAvailable = true, Price = 100, Sku = "WERT", Description = "des1" },
                new Product { Id = 7, CategoryId = 3, Name = "product 7", IsAvailable = true, Price = 200, Sku = "EERT", Description = "des1" },
                new Product { Id = 8, CategoryId = 4, Name = "product 8", IsAvailable = true, Price = 170, Sku = "VERT", Description = "des1" },
                new Product { Id = 9, CategoryId = 4, Name = "product 9", IsAvailable = true, Price = 130, Sku = "WEJT", Description = "des1" },
                new Product { Id = 10, CategoryId = 4, Name = "product 10", IsAvailable = true, Price = 190, Sku = "WERT", Description = "des1" });
        }
    }
}
