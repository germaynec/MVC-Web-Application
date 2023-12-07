using System;
using GeneralStoreMVC.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GeneralStoreMVC.Data
{
    public class GeneralStoreDbContext : DbContext
    {
        
        public GeneralStoreDbContext()
        {
        }

        public GeneralStoreDbContext(DbContextOptions<GeneralStoreDbContext> options) : base(options)
        {
        }

        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=EcommerceSite;User Id=sa;Password=[Catdogfan8$];Trusted_Connection=False;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomerEntity>().HasData(
                new CustomerEntity
                {
                    Id = 1001,
                    Name = "Louie",
                    Email = "LouietheDog@indy.gov"
                },
                new CustomerEntity
                {
                    Id = 1002,
                    Name = "Mowgli",
                    Email = "mowglithecat@yahoo.com"
                }
                
            );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity
                {
                    Id = 1001,
                    Name = "Glock 19",
                    QuantityInStock = 98,
                    Price = 499.99,
                },
                new ProductEntity
                {
                    Id = 1002,
                    Name = "Duty Belt",
                    QuantityInStock = 48,
                    Price = 199.99,
                }
                
            );

            modelBuilder.Entity<TransactionEntity>().HasData(
                new TransactionEntity
                {
                    Id = 1001,
                    Quantity = 3,
                    DateOfTransaction = DateTime.Now,
                    CustomerId = 1001,
                    ProductId = 1004
                },
                new TransactionEntity
                {
                    Id = 1002,
                    Quantity = 1,
                    DateOfTransaction = DateTime.Now,
                    CustomerId = 1004,
                    ProductId = 1001
                }
                
            );
        }
    }
}
