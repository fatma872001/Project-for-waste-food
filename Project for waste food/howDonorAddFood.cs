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
    public partial class howDonorAddFood : Form
    {
        public howDonorAddFood()
        {
            InitializeComponent();
        }

        private void howDonorAddFood_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();

        }

        private void type_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tot_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateBaseContext db = new DateBaseContext();
            db.Database.EnsureCreated();
            try 
            {
                Order Orders = new Order();
                Orders.OrderTypeName = type.Text;
                Orders.OrderQuantity = double.Parse(Tot_quantity.Text);
                Orders.OrderPrice = double.Parse(Tot_price.Text);

                Orders.desweight = double.Parse(T_D_weight.Text);
                Orders.desnumber = double.Parse(T_D_number.Text);
                Orders.desprice = double.Parse(T_D_price.Text);
                Orders.OrderItemExdate = T_D_exp.Text;

                Orders.OrderAddress= address.Text;
                if (phone.TextLength != 11)
                {
                    MessageBox.Show("Wrong Telephone No Please check it again",
                                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    phone.Text = " ";
                }
                else
                {
                    Orders.OrderPhone = phone.Text;
                   
                   
                }
               
                Orders.Orderyear = int.Parse(D_O_C_year.Text);
                Orders.Orderday = int.Parse(D_O_C_day.Text);
                Orders.Ordermonth = int.Parse(D_O_C_month.Text);
                Orders.OrderTime = D_O_C_time.Text;

                db.orders.Add(Orders);
                db.SaveChanges();
                MessageBox.Show("Posted Successfully");
                /*  var list = Doner_Controller.Vendors;

                  string userName = name.Text;
                  string password = Pass.Text;

                  var res = from sn in list
                            where sn.VendorName == userName && sn.VendorPassward == password
                            select sn;

                  Vendor s = res.FirstOrDefault(); */
                string userName = name.Text;
                string password = Pass.Text;
                var res = from c in db.vendors.ToList()
                          where c.VendorName == userName && c.VendorPassword == password
                          select c;

                Vendor s = res.FirstOrDefault();


                if (s != null )
                {
                    Profile profile = new Profile();
                    profile.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid or UserName or Password");

                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void T_D_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void D_O_C_time_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
