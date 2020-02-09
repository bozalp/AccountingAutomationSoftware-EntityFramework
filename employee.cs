using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace accounting_automation_software
{
    [Table("employee")]//for table name using System.ComponentModel.DataAnnotations.Schema;
    class employee
    {
        [Key, Required]//primary key and not null
        public string tc_no { get; set; }
        [StringLength(50)] //nvarchar(50)
        public string fname_lname { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public int salary { get; set; }
        public string iban { get; set; }
        public int d_no { get; set; }
    }
}
