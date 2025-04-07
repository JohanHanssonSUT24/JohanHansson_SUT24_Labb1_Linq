using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohanHansson_SUT24_Labb1_Linq.Models
{
   
    public class Menu
    {
        private readonly LINQ_Queries _linqQueries;

        public Menu(LINQ_Queries linqQueries)
        {
            _linqQueries = linqQueries;
        }

        public void ShowMenu()
        {
            bool exit = false;

            while(!exit)
            {
                Console.Clear();

                Console.WriteLine("[1] - Hämta alla Electronicsprodukter");
                Console.WriteLine("[2] - Leverantör med lågt lagersaldo");
                Console.WriteLine("[3] - Totalt ordervärde");
                Console.WriteLine("[4] - Topp3 produkter");
                Console.WriteLine("[5] - Kategorier och produkter");
                Console.WriteLine("[6] - Ordrar över 1000kr");
                Console.WriteLine("[0] - Avsluta");
                Console.Write("Ange ett alternativ: ");

                string userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "1":
                        Console.WriteLine("\n");
                        _linqQueries.AllElectronics();
                        Console.WriteLine("\nTryck på valfri tangent för att återvända till menyn.");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("\n");
                        _linqQueries.LowStock();
                        Console.WriteLine("\nTryck på valfri tangent för att återvända till menyn.");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("\n");
                        _linqQueries.TotalOrderValue();
                        Console.WriteLine("\nTryck på valfri tangent för att återvända till menyn.");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("\n");
                        _linqQueries.TopThreeProducts();
                        Console.WriteLine("\nTryck på valfri tangent för att återvända till menyn.");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("\n");
                        _linqQueries.CategoryAndProduct();
                        Console.WriteLine("\nTryck på valfri tangent för att återvända till menyn.");
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("\n");
                        _linqQueries.OrdersAboveThosand();
                        Console.WriteLine("\nTryck på valfri tangent för att återvända till menyn.");
                        Console.ReadKey();
                        break;

                    case "0":
                        exit = true;
                        break;

                    
                }
            }
        }
    }
}
