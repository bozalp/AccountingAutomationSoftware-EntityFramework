using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace accounting_automation_software
{
    [Table("sales")]//for table name using System.ComponentModel.DataAnnotations.Schema;
    class sales
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]//primary key and identity increment-> auto increment
        public int sales_id { get; set; }
        public int purchase_id{ get; set; }
        public string product_name { get; set; }
        public string customer_name { get; set; }
        public int customer_tel { get; set; }
        public int number_of_products_sold { get; set; }
        public int unit_price { get; set; }
        public string sell_date { get; set; }
        public int total_price { get; set; }
    }
}
