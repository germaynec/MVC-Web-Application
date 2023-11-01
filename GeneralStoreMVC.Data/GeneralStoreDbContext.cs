using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneralStoreMVC.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GeneralStoreMVC.Data;

public class GeneralStoreDbContext : DbContext
{
    public GeneralStoreDbContext(DbContextOptions<GeneralStoreDbContext> options) : base(options)
    {

    }

    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TransactionEntity> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<CustomerEntity>().HasData(
            new CustomerEntity
            {
                Id = 1001,
                Name = "Wayne Enterprises",
                Email = "batman4ever@wayne.org"
            },
            new CustomerEntity
            {
                Id = 1002,
                Name = "Palmer Technology",
                Email = "scienceiscool@gmail.com"
            },
            new CustomerEntity
            {
                Id = 1003,
                Name = "ACME Incorporated",
                Email = "anvil4life@icloud.com"
            },
            new CustomerEntity
            {
                Id = 1004,
                Name = "Ace Chemicals",
                Email = "thejokerrises@outlool.com"
            },
            new CustomerEntity
            {
                Id = 1005,
                Name = "Queen Industries",
                Email = "greenarrow98@queenindustries.org"
            },
            new CustomerEntity
            {
                Id = 1006,
                Name = "Queen Industries",
                Email = "greenarrow98@queenindustries.org"
            },
            new CustomerEntity
            {
                Id = 1007,
                Name = "Tony Stark",
                Email = "ironman@marvel.org"
            },
            new CustomerEntity
            {
                Id = 1008,
                Name = "Peter Parker",
                Email = "friendlyspider@marvel.org"
            },
            new CustomerEntity
            {
                Id = 1009,
                Name = "Bruce Banner",
                Email = "hulkoutgreen@marvel.org"
            }
        );

        modelBuilder.Entity<ProductEntity>().HasData(
            new ProductEntity
            {
                Id = 1001,
                Name = "Apple Airpods Max",
                QuantityInStock = 5,
                Price = 499.99,
            },
            new ProductEntity
            {
                Id = 1002,
                Name = "Apple Airpods Pro",
                QuantityInStock = 10,
                Price = 199.99,
            },
            new ProductEntity
            {
                Id = 1003,
                Name = "Apple MacBook Pro 14 M3 Pro",
                QuantityInStock = 15,
                Price = 1999.99,
            },
            new ProductEntity
            {
                Id = 1004,
                Name = "Ipad Pro 12.9",
                QuantityInStock = 7,
                Price = 1299.99,
            },
            new ProductEntity
            {
                Id = 1005,
                Name = "Ipad 10.9 10th Gen",
                QuantityInStock = 5,
                Price = 499.99,
            },
            new ProductEntity
            {
                Id = 1006,
                Name = "Playstation 5",
                QuantityInStock = 3,
                Price = 499.99,
            },
            new ProductEntity
            {
                Id = 1007,
                Name = "The Amazing Spiderman 2",
                QuantityInStock = 5,
                Price = 69.99,
            },
            new ProductEntity
            {
                Id = 1008,
                Name = "Diablo IV",
                QuantityInStock = 10,
                Price = 69.99,
            },
            new ProductEntity
            {
                Id = 1009,
                Name = "Horizon Forbidden West Complete Edition",
                QuantityInStock = 21,
                Price = 69.99,
            },
            new ProductEntity
            {
                Id = 1010,
                Name = "PS5 Purple Controller",
                QuantityInStock = 18,
                Price = 69.99,
            },
            new ProductEntity
            {
                Id = 1011,
                Name = "Nintendo Switch",
                QuantityInStock = 14,
                Price = 299.99,
            }
        );
    }
}
