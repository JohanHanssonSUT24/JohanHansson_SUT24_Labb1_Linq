using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JohanHansson_SUT24_Labb1_Linq.Models
{
    public class LINQ_Queries
    {
        private readonly EStoreContext _context;

        public LINQ_Queries(EStoreContext context)
        {
            _context = context;
        }

        public void AllElectronics()
        {
            var allElectronics = _context.Products
                                    .Where(p => p.Category.CategoryName == "Electronics")
                                    .OrderByDescending(p => p.ProductPrice)
                                    .ToList();

            foreach (var product in allElectronics)
            {
                Console.WriteLine($"Product: {product.ProductName}, Price: {product.ProductPrice}");
            }

        }
        public void LowStock()
        {
            var lowStock = _context.Suppliers
                                .Where(s => s.Products.Any(p => p.StockQuantity < 10))
                                .ToList();

            foreach(var product in lowStock)
            {
                Console.WriteLine($"Leverantör: {product.SupplierName}");
            }
        }

        public void TotalOrderValue()
        {
            var totalOrderValue = _context.Orders
                                       .Where(o => o.OrderDate > DateTime.Now.AddMonths(-1))
                                       .Sum(o => o.TotalAmount);
            Console.WriteLine($"Totalt ordervärde senaste månad: {totalOrderValue}");
        }

        public void TopThreeProducts()
        {
            var topThreeProducts = _context.OrderDetails
                .GroupBy(o => o.ProductId)
                .OrderByDescending(d => d.Sum(o => o.Quantity))
                .Take(3)
                .Select(s => new { Product = s.Key, TotalQuantity = s.Sum(o => o.Quantity) })
                .ToList();

            foreach (var product in topThreeProducts)
            {
                var item = _context.Products.First(p => p.ProductId == product.Product);
                Console.WriteLine($"Produkt: {item.ProductName}, Antal: {product.TotalQuantity}");
            }
        }

        public void CategoryAndProduct()
        {
            var categoryCount = _context.Categories
                .Select(c => new { Category = c.CategoryName, ProductCount = c.Products.Count() })
                .ToList();

            foreach(var category in categoryCount)
            {
                Console.WriteLine($"Kategori: {category.Category}, Antal produkter: {category.ProductCount}");
            }
        }

        public void OrdersAboveThosand()
        {
            var ordersAbove = _context.Orders
                .Where(o => o.TotalAmount > 1000)
                .Include(o => o.Customer)
                .Include(o => o.Details)
                .ThenInclude(d => d.Product)
                .ToList();

            foreach (var order in ordersAbove)
            {
                Console.WriteLine($"Order ID: {order.OrderId}, Kund: {order.Customer.CustomerName}, Totalbelopp: {order.TotalAmount}");
                foreach (var orderDetail in order.Details)
                {
                    Console.WriteLine($"Produkt: {orderDetail.Product.ProductName}, Antal: {orderDetail.Quantity}, Styckpris: {orderDetail.UnitPrice}");
                }
            }
        }
    }
}
