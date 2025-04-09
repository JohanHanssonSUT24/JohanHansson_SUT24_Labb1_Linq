using System.Net.Sockets;
using JohanHansson_SUT24_Labb1_Linq.Models;
using Microsoft.Extensions.Options;

namespace JohanHansson_SUT24_Labb1_Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EStoreContext()) //Create instance to communicate with DB
            {
                var linqQueries = new LINQ_Queries(context); //Create instance of LINQ_Queries to be able to use LINQ wih DB.

                var menu = new Menu(linqQueries);
                
                menu.ShowMenu();//Call menu
            }
        }
    }
}
