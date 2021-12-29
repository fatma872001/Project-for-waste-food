using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_waste_food
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderTypeName { get; set; }
        public double OrderPrice { get; set; }
        public string OrderAddress { get; set; }
        public string OrderPhone { get; set; }
        public double OrderQuantity { get; set; }
       // public virtual IEnumerable<OrderItem> OrderItems { get; set; }
        public Double desweight { get; set; }
        public Double desprice{ get; set; }
        public Double desnumber { get; set; }
        public string OrderItemExdate { get; set; }
        public int Orderyear { get; set; }
        public int Orderday { get; set; }
        public int Ordermonth { get; set; }
        public string OrderTime{ get; set; }
        public bool OrderCase { get; set; }
      //  public virtual Customer customer { get; set; }
        //public string OrderType { get; set; }




    }
}
