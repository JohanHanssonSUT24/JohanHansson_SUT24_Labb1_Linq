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
        private readonly EStoreContext _context;//Private readonly variable to prevent it from being tampered with

        public LINQ_Queries(EStoreContext context) //Constructor to initiate context
        {
            _context = context;
        }

        public void AllElectronics()//Method to show all products in Electronics
        {
            var allElectronics = _context.Products
                                    .Where(p => p.Category.CategoryName == "Electronics")//From Where(Category named Electronics). Sort by price in descending order
                                    .OrderByDescending(p => p.ProductPrice)
                                    .ToList();//Create list with result

            foreach (var product in allElectronics)//Iterate through list and display productname and price.
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Product: {product.ProductName}, Price: {product.ProductPrice}");
            }

        }
        public void LowStock()//Method to show suppliers with low stock-count
        {
            var lowStock = _context.Suppliers
                                .Include(s => s.Products)
                                .Where(s => s.Products.Any(p => p.StockQuantity < 10))//Filter suppliers where any products has a <10 stock-count
                                .ToList();

            foreach(var supplier in lowStock)
            {
                Console.WriteLine($"Leverantör: {supplier.SupplierName}");//Add suppliers name
                
                foreach (var product in supplier.Products.Where(p => p.StockQuantity < 10))//Show products with a stock count lower than 10.
                {
                    Console.WriteLine($"Produktnamn: {product.ProductName} Antal i lager: {product.StockQuantity}");
                }
                Console.WriteLine("---------------------------");
            }
           
        }

        public void TotalOrderValue()//Method for calculating total value of orders last 30 days
        {
            var totalOrderValue = _context.Orders
                                       .Where(o => o.OrderDate > DateTime.Now.AddMonths(-1))//Select orders from 1 month back
                                       .Sum(o => o.TotalAmount);//Calculate sum of the orders during last month. 
            Console.WriteLine($"Totalt ordervärde senaste månad: {totalOrderValue}");//Show results.
        }

        public void TopThreeProducts()//Method to see top 3 sold products
        {
            var topThreeProducts = _context.OrderDetails
                .GroupBy(o => o.ProductId)//Group the order details by ProductID
                .OrderByDescending(d => d.Sum(o => o.Quantity))//Order groups by total quantity in descending order.
                .Take(3)//Take the top three products with highest sale quantity
                .Select(s => new { Product = s.Key, TotalQuantity = s.Sum(o => o.Quantity) })
                .ToList();

            foreach (var product in topThreeProducts)
            {
                var item = _context.Products.First(p => p.ProductId == product.Product);
                Console.WriteLine($"Produkt: {item.ProductName}, Antal: {product.TotalQuantity}");
            }
        }

        public void CategoryAndProduct() //Method to list all number of products in each category
        {
            var categoryCount = _context.Categories
                .Select(c => new { Category = c.CategoryName, ProductCount = c.Products.Count() })//Select categoryname and number of products for each category
                .ToList();

            foreach(var category in categoryCount)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Kategori: {category.Category}, Antal produkter: {category.ProductCount}");
            }
        }

        public void OrdersAboveThousand()//Method to show all orders in total of above one thousand
        {
            var ordersAbove = _context.Orders
                .Where(o => o.TotalAmount > 1000)//Filter where orders are total amount of 1000 or higher.
                .Select(o => new
                {
                    OrderId = o.OrderId, //Select orderId, customer name, total amount and orderdetails for each order.
                    CustomerName = o.Customer.CustomerName,
                    TotalAmount = o.TotalAmount,
                    OrderDetails = o.Details.Select(d => new 
                    {
                        ProductName = d.Product.ProductName,//Select productname from orderdetails
                        Quantity = d.Quantity,//Select quantity of the product in the order
                        UnitPrice = d.UnitPrice,//Select unitprice of the product
                    }).ToList()//Convert selected orderdetails into a list
                })
                .ToList();//Execute the query and convert results into list.

            foreach (var order in ordersAbove)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Order ID: {order.OrderId}, Kund: {order.CustomerName}, Totalbelopp: {order.TotalAmount}");
                
                foreach (var orderDetail in order.OrderDetails)
                {
                    Console.WriteLine($"Produkt: {orderDetail.ProductName}, Antal: {orderDetail.Quantity}, Styckpris: {orderDetail.UnitPrice}");
                    
                }
            }
        }
    }
}
