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
    public partial class Home : Form
    {
        Order o;

        DateBaseContext db = new DateBaseContext();
        public Home()
        {
            InitializeComponent();
            db.Database.EnsureCreated();
            Order orderb = new Order();
            dataGridView1.DataSource = db.orders.Where(c => c.OrderCase == false).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                o = (from c in db.orders.ToList()
                     where c.Id == id
                     select c).FirstOrDefault();

              //  o.OrderCase = true;

                db.orders.Update(o);
                db.SaveChanges();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseAndSelectFood cho = new ChooseAndSelectFood();
            cho.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
            this.Hide();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
