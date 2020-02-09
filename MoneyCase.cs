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
    public partial class MoneyCase : Form
    {
        public MoneyCase()
        {
            InitializeComponent();
        }
        Accounting db = new Accounting();
        private void MoneyCase_Load(object sender, EventArgs e)
        {
            try
            {
                int sum1 = db.Purchase.Sum(x => x.product_price);
                sum1 = -1 * sum1;
                label1.Text = sum1.ToString();
                int sum2 = db.Sales.Sum(x => x.total_price);
                label2.Text = sum2.ToString();
                int average = sum1 + sum2;
                label3.Text = average.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
