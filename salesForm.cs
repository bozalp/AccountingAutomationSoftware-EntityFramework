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
    public partial class salesForm : Form
    {
        public salesForm()
        {
            InitializeComponent();
        }
        Accounting db = new Accounting();
        private void salesForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.Purchase.ToList();
                dataGridView2.DataSource = db.Sales.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.Purchase.ToList();
                dataGridView2.DataSource = db.Sales.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        //Search
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var filteredData = db.Purchase.Local.Where(x => x.product_name.Contains(this.textBox9.Text));
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
        //SELL
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(label1.Text);
                int id = Convert.ToInt32(label19.Text);
                if (count >= Convert.ToInt32(textBox15.Text))
                {
                    using (var context = new Accounting())
                    {
                        var sell = context.Purchase.Where(p => p.id == id).First();
                        count = count - Convert.ToInt32(textBox15.Text);
                        sell.number_of_products = Convert.ToInt32(count);
                        context.SaveChanges();
                        dataGridView1.DataSource = context.Purchase.ToList();
                        dataGridView2.DataSource = context.Sales.ToList();
                    }

                    int x = Convert.ToInt32(textBox1.Text);//unit price
                    int y = Convert.ToInt32(textBox15.Text);//count
                    db.Sales.Add(new sales
                    {
                        product_name = label21.Text,
                        customer_name = textBox16.Text,
                        customer_tel = Convert.ToInt32(textBox14.Text),
                        number_of_products_sold = Convert.ToInt32(textBox15.Text),
                        unit_price = Convert.ToInt32(textBox1.Text),
                        sell_date = dateTimePicker2.Text,
                        total_price = x * y,
                        purchase_id = Convert.ToInt32(label19.Text),
                    });
                    db.SaveChanges();
                    dataGridView2.DataSource = db.Sales.ToList();
                    MessageBox.Show("Sell Completed");
                    textBox1.Text = "";
                    textBox14.Text = "";
                    textBox16.Text = "";
                    textBox15.Text = "";
                }
                else
                    MessageBox.Show("Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label21.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//product name
                label19.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//id
                label1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();//count
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.Purchase.ToList();
                dataGridView2.DataSource = db.Sales.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var filteredData = db.Sales.Local.Where(x => x.product_name.Contains(this.textBox8.Text));
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
    }
}
