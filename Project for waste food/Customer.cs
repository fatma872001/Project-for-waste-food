using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_waste_food
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public string CustomerId { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
        public virtual IEnumerable<Vendor> Vendors { get; set; }


    }
}
