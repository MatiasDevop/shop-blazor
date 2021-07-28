using BlazorShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Video Games", Url = "video-games", Icon = "aperture" }
            );

            modelBuilder.Entity<Product>().HasData(
             new Product
             {
                 Id = 1,
                 CategoryId = 1,
                 Title = "The Hitchcker's guide tot he galaxy",
                 Description = "The hitchhiker's Guide to the Galaxy (sometimes referred to as H) is comedy science fiction series",
                 Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                 Price = 9.99m,
                 OriginalPrice = 19.99m,
                 DateCreated = new DateTime(2021, 1, 1)
             },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description = "Half-life 2 is a 2004 first person shooter game developed an published by value.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.99m,
                    OriginalPrice = 29.99m,
                    DateCreated = new DateTime(2021, 1, 1)
                },
                 new Product
                 {
                     Id = 3,
                     CategoryId = 1,
                     Title = "Nineteen Eighty-Four",
                     Description = "Nineteen Eigthy-four: A Novel, Often published as 1984, is a dystopian social",
                     Image = "https://upload.wikimedia.org/wikipedia/en/c/c3/1984first.jpg",
                     Price = 6.99m,
                     DateCreated = new DateTime(2021, 1, 1)
                 },
                 new Product
                 {
                     Id = 4,
                     CategoryId = 2,
                     Title = "Pentax Spotmatic",
                     Description = "The pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi",
                     Image = "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg",
                     Price = 166.66m,
                     OriginalPrice = 249.00m,
                     DateCreated = new DateTime(2021, 1, 1)
                 },
                  new Product
                  {
                      Id = 5,
                      CategoryId = 2,
                      Title = "XBox",
                      Description = "The Xbox is a home video game console and the first installment in the Xbox series....",
                      Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                      Price = 159.99m,
                      OriginalPrice = 299m,
                      DateCreated = new DateTime(2021, 1, 1)
                  },
                   new Product
                   {
                       Id = 6,
                       CategoryId = 2,
                       Title = "Super Nintendo Entertaimen System",
                       Description = "The Super Nintendo Entertaiment System(SNES), also known as the Super NES or super nintendo, is a16-bit home video game",
                       Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                       Price = 74.74m,
                       OriginalPrice = 400m,
                       DateCreated = new DateTime(2021, 1, 1)
                   },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Day of the Tentacle",
                    Description = "Day of the Tentacle , also known as Manica Mansion II",
                    Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_the_Tentacle_artwork.jpg",
                    Price = 14.74m,
                    DateCreated = new DateTime(2021, 1, 1)
                }
            );

            modelBuilder.Entity<Edition>().HasData(
                 new Edition { Id = 1, Name = "Paperback" },
                 new Edition { Id = 2, Name = "E-Book" },
                 new Edition { Id = 3, Name = "Audiobook" },
                 new Edition { Id = 4, Name = "PC" },
                 new Edition { Id = 5, Name = "PlayStation" },
                 new Edition { Id = 6, Name = "Xbox" }
                );

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct")
                .HasData(
                    new { EditionsId = 1, ProductsId = 1},
                    new { EditionsId = 2, ProductsId = 1 },
                    new { EditionsId = 3, ProductsId = 1 },
                    new { EditionsId = 1, ProductsId = 2 },
                    new { EditionsId = 2, ProductsId = 2 },
                    new { EditionsId = 4, ProductsId = 7 },
                    new { EditionsId = 5, ProductsId = 7 },
                    new { EditionsId = 6, ProductsId = 7 }
                );
        }

    }
}
