using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JohanHansson_SUT24_Labb1_Linq.Models
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Electronics", CategoryDescription = "Elektronik och tekniska produkter" },
                new Category { CategoryId = 2, CategoryName = "Home & Kitchen", CategoryDescription = "Produkter för hemmet och köket" },
                new Category { CategoryId = 3, CategoryName = "Clothing", CategoryDescription = "Kläder och accessoarer" },
                new Category { CategoryId = 4, CategoryName = "Sports", CategoryDescription = "Sportutrustning och träningsprodukter" },
                new Category { CategoryId = 5, CategoryName = "Books", CategoryDescription = "Böcker och litteratur" }
                );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { SupplierId = 1, SupplierName = "TechVision AB", SupplierContactPerson = "Anna Lindberg", SupplierEmail = "anna@techvision.se", SupplierPhone = "070-123-4567" },
                new Supplier { SupplierId = 2, SupplierName = "HomeStyle", SupplierContactPerson = "Johan Bergman", SupplierEmail = "johan@homestyle.se", SupplierPhone = "073-234-5678" },
                new Supplier { SupplierId = 3, SupplierName = "Fashion First", SupplierContactPerson = "Maria Ek", SupplierEmail = "maria@fashionfirst.se", SupplierPhone = "076-345-6789" },
                new Supplier { SupplierId = 4, SupplierName = "SportMax", SupplierContactPerson = "Erik Strand", SupplierEmail = "erik@sportmax.se", SupplierPhone = "072-456-7890" },
                new Supplier { SupplierId = 5, SupplierName = "Nordic Electronics", SupplierContactPerson = "Karl Holm", SupplierEmail = "karl@nordicelec.se", SupplierPhone = "070-567-8901" },
                new Supplier { SupplierId = 6, SupplierName = "Global Gadgets", SupplierContactPerson = "Lisa Björk", SupplierEmail = "lisa@globalgadgets.se", SupplierPhone = "073-678-9012" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "iPhone 13 Pro", ProductDescription = "Smartphone med 128GB lagring", ProductPrice = 11999, StockQuantity = 15, CategoryId = 1, SupplierId = 1 },
                new Product { ProductId = 2, ProductName = "Samsung TV 55\"", ProductDescription = "4K Smart TV med HDR", ProductPrice = 8999, StockQuantity = 8, CategoryId = 1, SupplierId = 5 },
                new Product { ProductId = 3, ProductName = "Sony WH-1000XM4", ProductDescription = "Trådlösa hörlurar med brusreducering", ProductPrice = 3499, StockQuantity = 7, CategoryId = 1, SupplierId = 5 },
                new Product { ProductId = 4, ProductName = "MacBook Air", ProductDescription = "Laptop med M1-chip och 8GB RAM", ProductPrice = 12499, StockQuantity = 12, CategoryId = 1, SupplierId = 1 },
                new Product { ProductId = 5, ProductName = "Espressomaskin", ProductDescription = "Automatisk espressomaskin", ProductPrice = 4995, StockQuantity = 6, CategoryId = 2, SupplierId = 2 },
                new Product { ProductId = 6, ProductName = "Matberedare", ProductDescription = "Multifunktionell köksmaskin", ProductPrice = 1299, StockQuantity = 20, CategoryId = 2, SupplierId = 2 },
                new Product { ProductId = 7, ProductName = "Vinterjacka", ProductDescription = "Varm jacka för vinterbruk", ProductPrice = 1999, StockQuantity = 25, CategoryId = 3, SupplierId = 3 },
                new Product { ProductId = 8, ProductName = "Löparskor", ProductDescription = "Skor för långdistanslöpning", ProductPrice = 1499, StockQuantity = 18, CategoryId = 4, SupplierId = 4 },
                new Product { ProductId = 9, ProductName = "Yogamatta", ProductDescription = "Halkfri yogamatta", ProductPrice = 349, StockQuantity = 30, CategoryId = 4, SupplierId = 4 },
                new Product { ProductId = 10, ProductName = "Bestsellerroman", ProductDescription = "Populär skönlitterär roman", ProductPrice = 249, StockQuantity = 40, CategoryId = 5, SupplierId = 2 },
                new Product { ProductId = 11, ProductName = "Gaming PC", ProductDescription = "Högpresterande dator för gaming", ProductPrice = 18999, StockQuantity = 5, CategoryId = 1, SupplierId = 6 },
                new Product { ProductId = 12, ProductName = "Tablet", ProductDescription = "10\" surfplatta med WiFi", ProductPrice = 4299, StockQuantity = 9, CategoryId = 1, SupplierId = 5 },
                new Product { ProductId = 13, ProductName = "Bluetooth-högtalare", ProductDescription = "Portabel högtalare med 20h batteritid", ProductPrice = 899, StockQuantity = 22, CategoryId = 1, SupplierId = 6 },
                new Product { ProductId = 14, ProductName = "Kaffebryggare", ProductDescription = "Programmerbar kaffebryggare", ProductPrice = 799, StockQuantity = 14, CategoryId = 2, SupplierId = 2 },
                new Product { ProductId = 15, ProductName = "Träningströja", ProductDescription = "Funktionströja för träning", ProductPrice = 499, StockQuantity = 35, CategoryId = 3, SupplierId = 3 }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, CustomerName = "Anders Svensson", CustomerEmail = "anders@example.com", CustomerPhone = "070-111-2233", CustomerAddress = "Storgatan 1, Stockholm" },
                new Customer { CustomerId = 2, CustomerName = "Emma Johansson", CustomerEmail = "emma@example.com", CustomerPhone = "073-222-3344", CustomerAddress = "Kungsgatan 15, Göteborg" },
                new Customer { CustomerId = 3, CustomerName = "Lars Nilsson", CustomerEmail = "lars@example.com", CustomerPhone = "076-333-4455", CustomerAddress = "Drottninggatan 8, Malmö" },
                new Customer { CustomerId = 4, CustomerName = "Sofia Lindgren", CustomerEmail = "sofia@example.com", CustomerPhone = "072-444-5566", CustomerAddress = "Sveavägen 22, Uppsala" },
                new Customer { CustomerId = 5, CustomerName = "Peter Karlsson", CustomerEmail = "peter@example.com", CustomerPhone = "070-555-6677", CustomerAddress = "Järntorget 5, Göteborg" }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, OrderDate = DateTime.Parse("2025-03-01"), CustomerId = 1, TotalAmount = 11999, OrderStatus = "Levererad" },
                new Order { OrderId = 2, OrderDate = DateTime.Parse("2025-03-05"), CustomerId = 2, TotalAmount = 9798, OrderStatus = "Levererad" },
                new Order { OrderId = 3, OrderDate = DateTime.Parse("2025-03-10"), CustomerId = 3, TotalAmount = 18999, OrderStatus = "Behandlas" },
                new Order { OrderId = 4, OrderDate = DateTime.Parse("2025-03-12"), CustomerId = 4, TotalAmount = 3499, OrderStatus = "Levererad" },
                new Order { OrderId = 5, OrderDate = DateTime.Parse("2025-03-15"), CustomerId = 5, TotalAmount = 16994, OrderStatus = "Skickad" },
                new Order { OrderId = 6, OrderDate = DateTime.Parse("2025-02-20"), CustomerId = 1, TotalAmount = 899, OrderStatus = "Levererad" },
                new Order { OrderId = 7, OrderDate = DateTime.Parse("2025-02-25"), CustomerId = 3, TotalAmount = 2498, OrderStatus = "Levererad" },
                new Order { OrderId = 8, OrderDate = DateTime.Parse("2025-03-18"), CustomerId = 2, TotalAmount = 1598, OrderStatus = "Skickad" },
                new Order { OrderId = 9, OrderDate = DateTime.Parse("2025-03-20"), CustomerId = 4, TotalAmount = 5794, OrderStatus = "Behandlas" },
                new Order { OrderId = 10, OrderDate = DateTime.Parse("2025-03-22"), CustomerId = 5, TotalAmount = 1299, OrderStatus = "Behandlas" }
                );

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderDetailId = 1, OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 11999 },
                new OrderDetail { OrderDetailId = 2, OrderId = 2, ProductId = 3, Quantity = 2, UnitPrice = 3499 },
                new OrderDetail { OrderDetailId = 3, OrderId = 2, ProductId = 13, Quantity = 3, UnitPrice = 899 },
                new OrderDetail { OrderDetailId = 4, OrderId = 3, ProductId = 11, Quantity = 1, UnitPrice = 18999 },
                new OrderDetail { OrderDetailId = 5, OrderId = 4, ProductId = 3, Quantity = 1, UnitPrice = 3499 },
                new OrderDetail { OrderDetailId = 6, OrderId = 5, ProductId = 4, Quantity = 1, UnitPrice = 12499 },
                new OrderDetail { OrderDetailId = 7, OrderId = 5, ProductId = 5, Quantity = 1, UnitPrice = 4495 },
                new OrderDetail { OrderDetailId = 8, OrderId = 6, ProductId = 13, Quantity = 1, UnitPrice = 899 },
                new OrderDetail { OrderDetailId = 9, OrderId = 7, ProductId = 8, Quantity = 1, UnitPrice = 1499 },
                new OrderDetail { OrderDetailId = 10, OrderId = 7, ProductId = 9, Quantity = 3, UnitPrice = 349 },
                new OrderDetail { OrderDetailId = 11, OrderId = 8, ProductId = 7, Quantity = 1, UnitPrice = 1999 },
                new OrderDetail { OrderDetailId = 12, OrderId = 8, ProductId = 15, Quantity = 3, UnitPrice = 499 },
                new OrderDetail { OrderDetailId = 13, OrderId = 9, ProductId = 2, Quantity = 1, UnitPrice = 8999 },
                new OrderDetail { OrderDetailId = 14, OrderId = 9, ProductId = 6, Quantity = 1, UnitPrice = 1299 },
                new OrderDetail { OrderDetailId = 15, OrderId = 9, ProductId = 14, Quantity = 2, UnitPrice = 799 },
                new OrderDetail { OrderDetailId = 16, OrderId = 10, ProductId = 6, Quantity = 1, UnitPrice = 1299 }
                );
        }
    }
}
