using System.Net.Sockets;
using JohanHansson_SUT24_Labb1_Linq.Models;
using Microsoft.Extensions.Options;

namespace JohanHansson_SUT24_Labb1_Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EStoreContext())
            {
                var linqQueries = new LINQ_Queries(context);

                var menu = new Menu(linqQueries);

                menu.ShowMenu();
            }
        }
    }
}
