using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accounting_automation_software
{
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }
        Accounting db = new Accounting();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Purchase.Add(new purchase
                {
                    product_name = textBox1.Text,
                    number_of_products = Convert.ToInt32(textBox2.Text),
                    properties = textBox3.Text,
                    company_name = textBox4.Text,
                    product_price = Convert.ToInt32(textBox5.Text),
                    purchase_date = dateTimePicker1.Text,
                });
                db.SaveChanges();
                MessageBox.Show("Purchase Added");
                dataGridView1.DataSource = db.Purchase.ToList();
                dataGridView2.DataSource = db.Purchase.ToList();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        private void refreshTable()
        {
            try
            {
                dataGridView1.DataSource = db.Purchase.ToList();
                dataGridView2.DataSource = db.Purchase.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var filteredData = db.Purchase.Local.Where(x => x.product_name.Contains(this.textBox8.Text));
                var count = filteredData.Count();
                if (count > 0)
                    dataGridView1.DataSource = filteredData.ToList();
                else
                    MessageBox.Show("Record is not found");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var filteredData = db.Purchase.Local.Where(x => x.product_name.Contains(this.textBox9.Text));
                var count = filteredData.Count();
                if (count > 0)
                    dataGridView2.DataSource = filteredData.ToList();
                else
                    MessageBox.Show("Record is not found");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label19.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();//id
                label21.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();//name
                textBox6.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();//id
                textBox7.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();//name
                textBox10.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();//number
                textBox11.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();//company
                textBox12.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();//price
                dateTimePicker2.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();//date
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            } 
        }

        //DELETE
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(label19.Text);
                using (var context = new Accounting())
                {
                    var delete = context.Purchase.Where(pur => pur.id == id).First();
                    context.Purchase.Remove(delete);
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Purchase.ToList();
                    dataGridView2.DataSource = context.Purchase.ToList();
                }
                MessageBox.Show("Delete Completed");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        //UPDATE
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(label19.Text);
                using (var context = new Accounting())
                {
                    var update = context.Purchase.Where(pur => pur.id == id).First();
                    update.product_name = textBox6.Text;
                    update.number_of_products = Convert.ToInt32(textBox7.Text);
                    update.properties = textBox10.Text;
                    update.company_name = textBox11.Text;
                    update.product_price = Convert.ToInt32(textBox12.Text);
                    update.purchase_date = dateTimePicker2.Text;
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Purchase.ToList();
                    dataGridView2.DataSource = context.Purchase.ToList();
                }
                MessageBox.Show("Update Completed");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
