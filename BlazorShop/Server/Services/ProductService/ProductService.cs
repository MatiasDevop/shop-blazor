using BlazorShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchcker's guide tot he galaxy",
                    Description = "The hitchhiker's Guide to the Galaxy (sometimes referred to as H) is comedy science fiction series",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description = "Half-life 2 is a 2004 first person shooter game developed an published by value.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.99m,
                    OriginalPrice = 29.99m
                },
                 new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Nineteen Eighty-Four",
                    Description = "Nineteen Eigthy-four: A Novel, Often published as 1984, is a dystopian social",
                    Image = "https://upload.wikimedia.org/wikipedia/en/c/c3/1984first.jpg",
                    Price = 6.99m,
                },
                 new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Pentax Spotmatic",
                    Description = "The pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg",
                    Price = 166.66m,
                    OriginalPrice = 249.00m
                },
                  new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "XBox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series....",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                    Price = 159.99m,
                    OriginalPrice = 299m
                },
                   new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Super Nintendo Entertaimen System",
                    Description = "The Super Nintendo Entertaiment System(SNES), also known as the Super NES or super nintendo, is a16-bit home video game",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    Price = 74.74m,
                    OriginalPrice = 400m
                }

            };
        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public Task<Product> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            throw new NotImplementedException();
        }
    }
}
