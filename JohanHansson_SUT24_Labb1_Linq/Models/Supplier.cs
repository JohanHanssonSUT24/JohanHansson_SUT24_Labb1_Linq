using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohanHansson_SUT24_Labb1_Linq.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContactPerson { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPhone { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
