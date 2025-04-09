using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohanHansson_SUT24_Labb1_Linq.Models
{
    //Entities for Order 
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount {  get; set; }
        public string OrderStatus {  get; set; }


        //Navigationprops
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> Details { get; set; }
    }
}
