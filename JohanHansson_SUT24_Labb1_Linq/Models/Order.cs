using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohanHansson_SUT24_Labb1_Linq.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount {  get; set; }
        public string Status {  get; set; }

        public Customer Customer { get; set; }
        public ICollection<OrderDetail> Details { get; set; }
    }
}
