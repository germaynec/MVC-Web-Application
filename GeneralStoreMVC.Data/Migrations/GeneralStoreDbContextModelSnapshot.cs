﻿// <auto-generated />
using System;
using GeneralStoreMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeneralStoreMVC.Data.Migrations
{
    [DbContext(typeof(GeneralStoreDbContext))]
    partial class GeneralStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeneralStoreMVC.Data.Entities.CustomerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            Email = "batman4ever@wayne.org",
                            Name = "Wayne Enterprises"
                        },
                        new
                        {
                            Id = 1002,
                            Email = "scienceiscool@gmail.com",
                            Name = "Palmer Technology"
                        },
                        new
                        {
                            Id = 1003,
                            Email = "anvil4life@icloud.com",
                            Name = "ACME Incorporated"
                        },
                        new
                        {
                            Id = 1004,
                            Email = "thejokerrises@outlool.com",
                            Name = "Ace Chemicals"
                        },
                        new
                        {
                            Id = 1005,
                            Email = "greenarrow98@queenindustries.org",
                            Name = "Queen Industries"
                        },
                        new
                        {
                            Id = 1006,
                            Email = "greenarrow98@queenindustries.org",
                            Name = "Queen Industries"
                        },
                        new
                        {
                            Id = 1007,
                            Email = "ironman@marvel.org",
                            Name = "Tony Stark"
                        },
                        new
                        {
                            Id = 1008,
                            Email = "friendlyspider@marvel.org",
                            Name = "Peter Parker"
                        },
                        new
                        {
                            Id = 1009,
                            Email = "hulkoutgreen@marvel.org",
                            Name = "Bruce Banner"
                        });
                });

            modelBuilder.Entity("GeneralStoreMVC.Data.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            Name = "Glock 19",
                            Price = 499.99000000000001,
                            QuantityInStock = 98
                        },
                        new
                        {
                            Id = 1002,
                            Name = "Duty Belt",
                            Price = 199.99000000000001,
                            QuantityInStock = 48
                        },
                        new
                        {
                            Id = 1003,
                            Name = "Police Car",
                            Price = 1999.99,
                            QuantityInStock = 61
                        },
                        new
                        {
                            Id = 1004,
                            Name = "X26 Taser",
                            Price = 1299.99,
                            QuantityInStock = 78
                        },
                        new
                        {
                            Id = 1005,
                            Name = "OCSC",
                            Price = 499.99000000000001,
                            QuantityInStock = 50
                        },
                        new
                        {
                            Id = 1006,
                            Name = "Glock 17",
                            Price = 499.99000000000001,
                            QuantityInStock = 55
                        },
                        new
                        {
                            Id = 1007,
                            Name = "Baton",
                            Price = 69.989999999999995,
                            QuantityInStock = 35
                        },
                        new
                        {
                            Id = 1008,
                            Name = "Mag Pouch",
                            Price = 69.989999999999995,
                            QuantityInStock = 42
                        },
                        new
                        {
                            Id = 1009,
                            Name = "Nylonm Mag Pouch",
                            Price = 69.989999999999995,
                            QuantityInStock = 101
                        },
                        new
                        {
                            Id = 1010,
                            Name = "Radio Holster",
                            Price = 69.989999999999995,
                            QuantityInStock = 108
                        },
                        new
                        {
                            Id = 1011,
                            Name = "Body Camera",
                            Price = 299.99000000000001,
                            QuantityInStock = 104
                        });
                });

            modelBuilder.Entity("GeneralStoreMVC.Data.Entities.TransactionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfTransaction")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            CustomerId = 1001,
                            DateOfTransaction = new DateTime(2023, 11, 2, 16, 47, 42, 484, DateTimeKind.Local).AddTicks(8930),
                            ProductId = 1004,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 1002,
                            CustomerId = 1004,
                            DateOfTransaction = new DateTime(2023, 11, 2, 16, 47, 42, 484, DateTimeKind.Local).AddTicks(8980),
                            ProductId = 1001,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 1003,
                            CustomerId = 1002,
                            DateOfTransaction = new DateTime(2023, 11, 2, 16, 47, 42, 484, DateTimeKind.Local).AddTicks(8980),
                            ProductId = 1011,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 1004,
                            CustomerId = 1008,
                            DateOfTransaction = new DateTime(2023, 11, 2, 16, 47, 42, 484, DateTimeKind.Local).AddTicks(8980),
                            ProductId = 1010,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 1005,
                            CustomerId = 1008,
                            DateOfTransaction = new DateTime(2023, 11, 2, 16, 47, 42, 484, DateTimeKind.Local).AddTicks(8990),
                            ProductId = 1003,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 1006,
                            CustomerId = 1002,
                            DateOfTransaction = new DateTime(2023, 11, 2, 16, 47, 42, 484, DateTimeKind.Local).AddTicks(8990),
                            ProductId = 1007,
                            Quantity = 6
                        },
                        new
                        {
                            Id = 1007,
                            CustomerId = 1006,
                            DateOfTransaction = new DateTime(2023, 11, 2, 16, 47, 42, 484, DateTimeKind.Local).AddTicks(8990),
                            ProductId = 1009,
                            Quantity = 10
                        });
                });

            modelBuilder.Entity("GeneralStoreMVC.Data.Entities.TransactionEntity", b =>
                {
                    b.HasOne("GeneralStoreMVC.Data.Entities.CustomerEntity", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeneralStoreMVC.Data.Entities.ProductEntity", "Product")
                        .WithMany("Transactions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GeneralStoreMVC.Data.Entities.CustomerEntity", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("GeneralStoreMVC.Data.Entities.ProductEntity", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
