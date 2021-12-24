using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_waste_food
{
    public class Customer
    {
        private string customerId;
        public string CustomerPassward { get; set; }
        public string CustomerAddresss { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public string CustomerId { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
        public virtual IEnumerable<Vendor> Vendors { get; set; }


    }
}
