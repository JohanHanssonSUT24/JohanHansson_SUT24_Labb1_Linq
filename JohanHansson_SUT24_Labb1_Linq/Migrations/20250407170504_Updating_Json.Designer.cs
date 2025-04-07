﻿// <auto-generated />
using System;
using JohanHansson_SUT24_Labb1_Linq.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JohanHansson_SUT24_Labb1_Linq.Migrations
{
    [DbContext(typeof(EStoreContext))]
    [Migration("20250407170504_Updating_Json")]
    partial class Updating_Json
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Elektronik och tekniska produkter",
                            CategoryName = "Electronics"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Produkter för hemmet och köket",
                            CategoryName = "Home & Kitchen"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Kläder och accessoarer",
                            CategoryName = "Clothing"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryDescription = "Sportutrustning och träningsprodukter",
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryDescription = "Böcker och litteratur",
                            CategoryName = "Books"
                        });
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CustomerAddress = "Storgatan 1, Stockholm",
                            CustomerEmail = "anders@example.com",
                            CustomerName = "Anders Svensson",
                            CustomerPhone = "070-111-2233"
                        },
                        new
                        {
                            CustomerId = 2,
                            CustomerAddress = "Kungsgatan 15, Göteborg",
                            CustomerEmail = "emma@example.com",
                            CustomerName = "Emma Johansson",
                            CustomerPhone = "073-222-3344"
                        },
                        new
                        {
                            CustomerId = 3,
                            CustomerAddress = "Drottninggatan 8, Malmö",
                            CustomerEmail = "lars@example.com",
                            CustomerName = "Lars Nilsson",
                            CustomerPhone = "076-333-4455"
                        },
                        new
                        {
                            CustomerId = 4,
                            CustomerAddress = "Sveavägen 22, Uppsala",
                            CustomerEmail = "sofia@example.com",
                            CustomerName = "Sofia Lindgren",
                            CustomerPhone = "072-444-5566"
                        },
                        new
                        {
                            CustomerId = 5,
                            CustomerAddress = "Järntorget 5, Göteborg",
                            CustomerEmail = "peter@example.com",
                            CustomerName = "Peter Karlsson",
                            CustomerPhone = "070-555-6677"
                        });
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CustomerId = 1,
                            OrderDate = new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Levererad",
                            TotalAmount = 11999m
                        },
                        new
                        {
                            OrderId = 2,
                            CustomerId = 2,
                            OrderDate = new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Levererad",
                            TotalAmount = 9798m
                        },
                        new
                        {
                            OrderId = 3,
                            CustomerId = 3,
                            OrderDate = new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Behandlas",
                            TotalAmount = 18999m
                        },
                        new
                        {
                            OrderId = 4,
                            CustomerId = 4,
                            OrderDate = new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Levererad",
                            TotalAmount = 3499m
                        },
                        new
                        {
                            OrderId = 5,
                            CustomerId = 5,
                            OrderDate = new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Skickad",
                            TotalAmount = 16994m
                        },
                        new
                        {
                            OrderId = 6,
                            CustomerId = 1,
                            OrderDate = new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Levererad",
                            TotalAmount = 899m
                        },
                        new
                        {
                            OrderId = 7,
                            CustomerId = 3,
                            OrderDate = new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Levererad",
                            TotalAmount = 2498m
                        },
                        new
                        {
                            OrderId = 8,
                            CustomerId = 2,
                            OrderDate = new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Skickad",
                            TotalAmount = 1598m
                        },
                        new
                        {
                            OrderId = 9,
                            CustomerId = 4,
                            OrderDate = new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Behandlas",
                            TotalAmount = 5794m
                        },
                        new
                        {
                            OrderId = 10,
                            CustomerId = 5,
                            OrderDate = new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatus = "Behandlas",
                            TotalAmount = 1299m
                        });
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            OrderDetailId = 1,
                            OrderId = 1,
                            ProductId = 1,
                            Quantity = 1,
                            UnitPrice = 11999m
                        },
                        new
                        {
                            OrderDetailId = 2,
                            OrderId = 2,
                            ProductId = 3,
                            Quantity = 2,
                            UnitPrice = 3499m
                        },
                        new
                        {
                            OrderDetailId = 3,
                            OrderId = 2,
                            ProductId = 13,
                            Quantity = 3,
                            UnitPrice = 899m
                        },
                        new
                        {
                            OrderDetailId = 4,
                            OrderId = 3,
                            ProductId = 11,
                            Quantity = 1,
                            UnitPrice = 18999m
                        },
                        new
                        {
                            OrderDetailId = 5,
                            OrderId = 4,
                            ProductId = 3,
                            Quantity = 1,
                            UnitPrice = 3499m
                        },
                        new
                        {
                            OrderDetailId = 6,
                            OrderId = 5,
                            ProductId = 4,
                            Quantity = 1,
                            UnitPrice = 12499m
                        },
                        new
                        {
                            OrderDetailId = 7,
                            OrderId = 5,
                            ProductId = 5,
                            Quantity = 1,
                            UnitPrice = 4495m
                        },
                        new
                        {
                            OrderDetailId = 8,
                            OrderId = 6,
                            ProductId = 13,
                            Quantity = 1,
                            UnitPrice = 899m
                        },
                        new
                        {
                            OrderDetailId = 9,
                            OrderId = 7,
                            ProductId = 8,
                            Quantity = 1,
                            UnitPrice = 1499m
                        },
                        new
                        {
                            OrderDetailId = 10,
                            OrderId = 7,
                            ProductId = 9,
                            Quantity = 3,
                            UnitPrice = 349m
                        },
                        new
                        {
                            OrderDetailId = 11,
                            OrderId = 8,
                            ProductId = 7,
                            Quantity = 1,
                            UnitPrice = 1999m
                        },
                        new
                        {
                            OrderDetailId = 12,
                            OrderId = 8,
                            ProductId = 15,
                            Quantity = 3,
                            UnitPrice = 499m
                        },
                        new
                        {
                            OrderDetailId = 13,
                            OrderId = 9,
                            ProductId = 2,
                            Quantity = 1,
                            UnitPrice = 8999m
                        },
                        new
                        {
                            OrderDetailId = 14,
                            OrderId = 9,
                            ProductId = 6,
                            Quantity = 1,
                            UnitPrice = 1299m
                        },
                        new
                        {
                            OrderDetailId = 15,
                            OrderId = 9,
                            ProductId = 14,
                            Quantity = 2,
                            UnitPrice = 799m
                        },
                        new
                        {
                            OrderDetailId = 16,
                            OrderId = 10,
                            ProductId = 6,
                            Quantity = 1,
                            UnitPrice = 1299m
                        });
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ProductDescription = "Smartphone med 128GB lagring",
                            ProductName = "iPhone 13 Pro",
                            ProductPrice = 11999m,
                            StockQuantity = 15,
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            ProductDescription = "4K Smart TV med HDR",
                            ProductName = "Samsung TV 55\"",
                            ProductPrice = 8999m,
                            StockQuantity = 8,
                            SupplierId = 5
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            ProductDescription = "Trådlösa hörlurar med brusreducering",
                            ProductName = "Sony WH-1000XM4",
                            ProductPrice = 3499m,
                            StockQuantity = 7,
                            SupplierId = 5
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            ProductDescription = "Laptop med M1-chip och 8GB RAM",
                            ProductName = "MacBook Air",
                            ProductPrice = 12499m,
                            StockQuantity = 12,
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            ProductDescription = "Automatisk espressomaskin",
                            ProductName = "Espressomaskin",
                            ProductPrice = 4995m,
                            StockQuantity = 6,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            ProductDescription = "Multifunktionell köksmaskin",
                            ProductName = "Matberedare",
                            ProductPrice = 1299m,
                            StockQuantity = 20,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            ProductDescription = "Varm jacka för vinterbruk",
                            ProductName = "Vinterjacka",
                            ProductPrice = 1999m,
                            StockQuantity = 25,
                            SupplierId = 3
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4,
                            ProductDescription = "Skor för långdistanslöpning",
                            ProductName = "Löparskor",
                            ProductPrice = 1499m,
                            StockQuantity = 18,
                            SupplierId = 4
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 4,
                            ProductDescription = "Halkfri yogamatta",
                            ProductName = "Yogamatta",
                            ProductPrice = 349m,
                            StockQuantity = 30,
                            SupplierId = 4
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 5,
                            ProductDescription = "Populär skönlitterär roman",
                            ProductName = "Bestsellerroman",
                            ProductPrice = 249m,
                            StockQuantity = 40,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1,
                            ProductDescription = "Högpresterande dator för gaming",
                            ProductName = "Gaming PC",
                            ProductPrice = 18999m,
                            StockQuantity = 5,
                            SupplierId = 6
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 1,
                            ProductDescription = "10\" surfplatta med WiFi",
                            ProductName = "Tablet",
                            ProductPrice = 4299m,
                            StockQuantity = 9,
                            SupplierId = 5
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 1,
                            ProductDescription = "Portabel högtalare med 20h batteritid",
                            ProductName = "Bluetooth-högtalare",
                            ProductPrice = 899m,
                            StockQuantity = 22,
                            SupplierId = 6
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 2,
                            ProductDescription = "Programmerbar kaffebryggare",
                            ProductName = "Kaffebryggare",
                            ProductPrice = 799m,
                            StockQuantity = 14,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 3,
                            ProductDescription = "Funktionströja för träning",
                            ProductName = "Träningströja",
                            ProductPrice = 499m,
                            StockQuantity = 35,
                            SupplierId = 3
                        });
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("SupplierContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            SupplierContactPerson = "Anna Lindberg",
                            SupplierEmail = "anna@techvision.se",
                            SupplierName = "TechVision AB",
                            SupplierPhone = "070-123-4567"
                        },
                        new
                        {
                            SupplierId = 2,
                            SupplierContactPerson = "Johan Bergman",
                            SupplierEmail = "johan@homestyle.se",
                            SupplierName = "HomeStyle",
                            SupplierPhone = "073-234-5678"
                        },
                        new
                        {
                            SupplierId = 3,
                            SupplierContactPerson = "Maria Ek",
                            SupplierEmail = "maria@fashionfirst.se",
                            SupplierName = "Fashion First",
                            SupplierPhone = "076-345-6789"
                        },
                        new
                        {
                            SupplierId = 4,
                            SupplierContactPerson = "Erik Strand",
                            SupplierEmail = "erik@sportmax.se",
                            SupplierName = "SportMax",
                            SupplierPhone = "072-456-7890"
                        },
                        new
                        {
                            SupplierId = 5,
                            SupplierContactPerson = "Karl Holm",
                            SupplierEmail = "karl@nordicelec.se",
                            SupplierName = "Nordic Electronics",
                            SupplierPhone = "070-567-8901"
                        },
                        new
                        {
                            SupplierId = 6,
                            SupplierContactPerson = "Lisa Björk",
                            SupplierEmail = "lisa@globalgadgets.se",
                            SupplierName = "Global Gadgets",
                            SupplierPhone = "073-678-9012"
                        });
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Order", b =>
                {
                    b.HasOne("JohanHansson_SUT24_Labb1_Linq.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.OrderDetail", b =>
                {
                    b.HasOne("JohanHansson_SUT24_Labb1_Linq.Models.Order", "Order")
                        .WithMany("Details")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JohanHansson_SUT24_Labb1_Linq.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Product", b =>
                {
                    b.HasOne("JohanHansson_SUT24_Labb1_Linq.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JohanHansson_SUT24_Labb1_Linq.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Order", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("JohanHansson_SUT24_Labb1_Linq.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
