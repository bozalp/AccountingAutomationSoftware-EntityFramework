using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace accounting_automation_software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void create_table()
        {
            Accounting table = new Accounting();
            table.Database.Create();
            MessageBox.Show("table created");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //create_table();
        }

        private void emp_add_button_Click(object sender, EventArgs e)
        {
            emp_add emp = new emp_add();
            emp.Show();
        }

        private void git_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bozalp");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dept_add dd = new dept_add();
            dd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PurchaseForm p = new PurchaseForm();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            salesForm s = new salesForm();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MoneyCase m = new MoneyCase();
            m.Show();
        }
    }
}
