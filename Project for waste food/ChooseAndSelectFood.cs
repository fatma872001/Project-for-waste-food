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
    public partial class ChooseAndSelectFood : Form
    {
        Order o;
        public ChooseAndSelectFood()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateBaseContext db = new DateBaseContext();
            string userName = textBox1.Text;
            string password = Pass.Text;

            var res = from c in db.customers.ToList()
                      where c.CustomerName == userName && c.CustomerPassword == password
                      select c;

            Customer s = res.FirstOrDefault();

            if (s != null)
            {
                MessageBox.Show("Done please call the vendor");
            }
            else
            {
                MessageBox.Show("Invalid or UserName or Password");
            }

            o = (from c in db.orders.ToList()
                 where c.Id == int.Parse(textBox4.Text)
                 select c).FirstOrDefault();

            o.OrderCase = true;

            db.orders.Update(o);
            db.SaveChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home bk = new Home();
            bk.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void ChooseAndSelectFood_Load(object sender, EventArgs e)
        {

        }
    }
}
