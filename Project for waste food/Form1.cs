using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            log_in a = new log_in();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
           log_in ch = new log_in();
            ch.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            log_in ch = new log_in();
            ch.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            log_in ch = new log_in();
            ch.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("If you want to be part of our comunity, please contact with us via 01019011277", "Sign Up", MessageBoxButtons.OK);
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            signUpAsCharity c = new signUpAsCharity();
            c.Show();
        }
       

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Process.Start("facebook.com");
            //LinkLabel.Link link = new LinkLabel.Link();
            //link.LinkData = "http://www.codeproject.com";
            //linkLabel1.Links.Add(link);
         //   webBrowser1.Navigate("http://twit.tv/");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("www.google.com");
            }
            catch
            {

            }
        }
    }

}
