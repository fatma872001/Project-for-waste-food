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
        public log_in()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                var list = Admin_Controler.Admins;

                string userName = textBox1.Text;
                string password = textBox2.Text;

                var res = from sn in list
                          where sn.AdminId == userName && sn.AdminPassward== password
                          select sn;

                Admin s = res.FirstOrDefault();

                if (s != null)
                {
                log_in loginAdmin = new log_in();
                loginAdmin.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid or UserName or Password");
                }
        }
    }
}
