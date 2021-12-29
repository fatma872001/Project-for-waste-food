using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_waste_food
{
    class Doner_Controller
    {
        public static List<Vendor> Vendors = new List<Vendor>();
        static Doner_Controller()
        {
            Vendor v1 = new Vendor() { VendorName = "resala", VendorMail = "fatma5@gmail.com", VendorPassword = "1234" };
            Vendor v2 = new Vendor() { VendorName = "bank", VendorMail = "fatma6@gmail.com", VendorPassword = "6567" };
            Vendor v3 = new Vendor() { VendorName = "sss", VendorMail = "fatma1@gmail.com", VendorPassword = "891011" };
            
            Vendors.Add(v1);
            Vendors.Add(v2);
            Vendors.Add(v3);
          


        }
    }
}
