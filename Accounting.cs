using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace accounting_automation_software
{
    class Accounting:DbContext
    {
        public DbSet<employee> Employee { get; set; }
        public DbSet<department> Department { get; set; }
        public DbSet<purchase> Purchase { get; set; }
        public DbSet<sales> Sales { get; set; }

    }
}
