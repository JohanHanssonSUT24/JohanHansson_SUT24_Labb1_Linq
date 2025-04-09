using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JohanHansson_SUT24_Labb1_Linq.Models
{
    public class EStoreContext : DbContext
    {   
        private static IConfiguration _configuration = new ConfigurationBuilder() //Instance of IConfiguration to get information from json-file
            .SetBasePath(Directory.GetCurrentDirectory())// Set given directory
            .AddJsonFile("appsettings.json")//Pathway
            .Build();

        //Create DbSets for tables in DB
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Connect to DB using OnConfiguring
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));//UseSqlServer - Function to instruct EF to use SQL Server
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //Create the basic configurations of DB 
            SeedData.Seed(modelBuilder); // Add seeddata to DB

        }

    }
}
