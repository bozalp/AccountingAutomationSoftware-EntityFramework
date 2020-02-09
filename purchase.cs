using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace accounting_automation_software
{
    [Table("purchase")]//for table name using System.ComponentModel.DataAnnotations.Schema;
    class purchase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]//primary key and identity increment-> auto increment
        public int id { get; set; }
        public string product_name { get; set; }
        public int number_of_products { get; set; }
        public string properties { get; set; }
        public string company_name { get; set; }
        public int product_price { get; set; }
        public string purchase_date { get; set; }

    }
}
