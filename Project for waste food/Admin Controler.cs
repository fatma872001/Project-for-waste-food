using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_waste_food
{
    class Admin_Controler
    {
            public static List<Admin> Admins = new List<Admin>();
            static Admin_Controler()
            {
                Admin a1 = new Admin() { AdminName = "Fatma Morsy", AdminMail ="fatma5@gmail.com" , AdminPassword= "1234" };
                Admin a2 = new Admin() { AdminName = "Fatma Magdy", AdminMail = "fatma6@gmail.com", AdminPassword = "6567" };
                Admin a3 = new Admin() { AdminName = "Fatma Othman", AdminMail = "fatma1@gmail.com", AdminPassword = "891011" };
                Admin a4 = new Admin() { AdminName = "Fatma Atef", AdminMail = "fatma7@gmail.com", AdminPassword = "12131415" };
            
               Admins.Add(a1);
               Admins.Add(a2);
               Admins.Add(a3);
               Admins.Add(a4);
               
            }
    }
}
