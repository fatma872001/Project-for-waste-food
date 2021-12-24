using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_waste_food
{
    public class Vendor
    {
        private string vendorId;
        public string VendorPassward { get; set; }
        public string VendorAddresss { get; set; }
        public string VendorMail { get; set; }
        public string VendorPhone { get; set; }
        public string VendorName { get; set; }
        public string VendorType { get; set; }
        public string VendorId { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
        public virtual IEnumerable<Customer> Customers { get; set; }


    }
}
