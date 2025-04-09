using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohanHansson_SUT24_Labb1_Linq.Models
{
    public class Customer
    {
        //Entities for Customer
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }

        //Navigationprop
        public ICollection<Order> Orders { get; set; }
    }
}
