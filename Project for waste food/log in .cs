using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_waste_food
{
    public partial class log_in : Form
    {
        private object customers;
        public log_in()
        {
            InitializeComponent();
            loginAdmin = this;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }
        log_in loginAdmin = null;
        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {

                var list = Admin_Controler.Admins;

                string userName = textBox1.Text;
                string password = textBox2.Text;

                var res = from sn in list
                          where sn.AdminName == userName && sn.AdminPassword == password
                          select sn;

                Admin s = res.FirstOrDefault();

                if (s != null)
                {
                   Home_Admin home = new Home_Admin();
                   home.Show();
                    loginAdmin.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid or UserName or Password");
                }
            }
            else if (radioButton2.Checked == true)
            {
                /* var list = Doner_Controller.Vendors;

                 string userName = textBox1.Text;
                 string password = textBox2.Text;

                 var res = from sn in list
                           where sn.VendorName == userName && sn.VendorPassward == password
                           select sn;

                 Vendor s = res.FirstOrDefault();

                 if (s != null)
                 {
                     Profile profile = new Profile();
                     profile.Show();
                     loginAdmin.Hide();
                 }
                 else
                 {
                     MessageBox.Show("Invalid or UserName or Password");
                 }*/
                DateBaseContext db = new DateBaseContext();
                string userName = textBox1.Text;
                string password = textBox2.Text;
                var res = from c in db.vendors.ToList()
                          where c.VendorName == userName && c.VendorPassword == password
                          select c;

                Vendor s = res.FirstOrDefault();

                if (s != null)
                {
                    StroreData.v = s;
                    Profile profile = new Profile();
                    profile.Show();
                    loginAdmin.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid or UserName or Password");
                }

            }
        
            else if (radioButton3.Checked == true)
            {
                DateBaseContext db = new DateBaseContext();
                string userName = textBox1.Text;
                string password = textBox2.Text;

                var res = from c in db.customers.ToList()
                          where c.CustomerName == userName && c.CustomerPassword == password
                          select c;

                Customer s = res.FirstOrDefault();

                if (s != null)
                {
                    Home logInAsCharity = new Home();
                    logInAsCharity.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid or UserName or Password");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signUpAsCharity s = new signUpAsCharity();
            s.Show();
            loginAdmin.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
