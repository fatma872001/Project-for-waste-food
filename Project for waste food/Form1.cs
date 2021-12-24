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
  
    public partial class Form1 : Form
    {
        public string type = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            log_in a = new log_in();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log_in c= new log_in();
           c.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            log_in v= new log_in();
           v.Show();
        }
    }

}
