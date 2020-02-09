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
    public partial class dept_add : Form
    {
        public dept_add()
        {
            InitializeComponent();
        }
        Accounting db = new Accounting();
        private void dept_add_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.Department.ToList();
                dataGridView2.DataSource = db.Department.ToList();

                var query = db.Employee.Select(
                    x => x.tc_no
                    );
                foreach (var item in query)
                {
                    comboBox1.Items.Add(item);
                    comboBox2.Items.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Department.Add(new department
            {
                d_no = textBox1.Text,
                d_name = textBox2.Text,
                mgr_tc = comboBox1.Text
            });
                db.SaveChanges();
                MessageBox.Show("Department Added");
                dataGridView1.DataSource = db.Department.ToList();
                dataGridView2.DataSource = db.Department.ToList();
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
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
                var filteredData = db.Department.Local.Where(x => x.d_name.Contains(this.textBox8.Text));
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.Department.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = db.Department.ToList();
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
                var filteredData = db.Department.Local.Where(x => x.d_name.Contains(this.textBox9.Text));
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
                textBox15.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();//dno
                label21.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();//dno
                textBox16.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();//dname
                comboBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();//tc no
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }  
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string tc = label21.Text;
                using (var context = new Accounting())
                {
                    var delete = context.Department.Where(d => d.d_no == tc).First();
                    context.Department.Remove(delete);
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Department.ToList();
                    dataGridView2.DataSource = context.Department.ToList();
                }
                MessageBox.Show("Delete Completed");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                string dno = label21.Text;
                using (var context = new Accounting())
                {
                    var update = context.Department.Where(d => d.d_no == dno).First();
                    //update.d_no = textBox15.Text;
                    update.d_name = textBox16.Text;
                    update.mgr_tc = comboBox2.Text;
                    
                    dataGridView1.DataSource = context.Department.ToList();
                    dataGridView2.DataSource = context.Department.ToList();
                    context.SaveChanges();
                    
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
