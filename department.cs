using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace accounting_automation_software
{
    [Table("department")]//for table name using System.ComponentModel.DataAnnotations.Schema;
    class department
    {
        [Key, Required]//primary key and not null
        public string d_no { get; set; }
        public string d_name { get; set; }
        public string mgr_tc { get; set; }
    }
}
