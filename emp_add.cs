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
    public partial class emp_add : Form
    {
        public emp_add()
        {
            InitializeComponent();
        }

        Accounting db = new Accounting();
        private void emp_add_Load(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.DataSource = db.Employee.ToList();
                dataGridView2.DataSource = db.Employee.ToList();

                var query = db.Department.Select(
                    x => x.d_no
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

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                db.Employee.Add(new employee
            {
                tc_no = textBox1.Text,
                fname_lname = textBox2.Text,
                tel1 = textBox3.Text,
                tel2 = textBox4.Text,
                salary = Convert.ToInt32(textBox6.Text),
                iban = textBox7.Text,
                d_no = Convert.ToInt32(comboBox1.Text)
            });
                db.SaveChanges();
                MessageBox.Show("Employee Added");
                dataGridView1.DataSource = db.Employee.ToList();
                dataGridView2.DataSource = db.Employee.ToList();

                label21.Text = "00000000000";
                label22.Text = "x";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                comboBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = db.Employee.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void refresh2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = db.Employee.ToList();
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
                var filteredData = db.Employee.Local.Where(x => x.tc_no.Contains(this.textBox8.Text));
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label21.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();//tc no
                label22.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();//fname lname

                textBox16.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();//tc
                textBox15.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();//fname lname
                textBox14.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();//tel1
                textBox13.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();//tel2
                textBox11.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();//salary
                textBox10.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();//iban
                comboBox2.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();//dno
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
                string tc = label21.Text;
                using (var context = new Accounting())
                {
                    var update = context.Employee.Where(emp => emp.tc_no == tc).First();
                    //update.tc_no = textBox16.Text;
                    //Additional information: The property 'tc_no' is part of the object's key information and cannot be modified.
                    //so i can't change this field
                    update.fname_lname = textBox15.Text;
                    update.tel1 = textBox14.Text;
                    update.tel2 = textBox13.Text;
                    update.salary = Convert.ToInt32(textBox11.Text);
                    update.iban = textBox10.Text;
                    update.d_no = Convert.ToInt32(comboBox2.Text);
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Employee.ToList();
                    dataGridView2.DataSource = context.Employee.ToList();
                }
                MessageBox.Show("Update Completed");
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
                var filteredData = db.Employee.Local.Where(x => x.fname_lname.Contains(this.textBox17.Text));
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

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string tc = label21.Text;
                using (var context = new Accounting())
                {
                    var delete = context.Employee.Where(emp => emp.tc_no == tc).First();
                    context.Employee.Remove(delete);
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Employee.ToList();
                    dataGridView2.DataSource = context.Employee.ToList();
                }
                MessageBox.Show("Delete Completed");
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
                var filteredData = db.Employee.Local.Where(x => x.tc_no.Contains(this.textBox9.Text));
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
