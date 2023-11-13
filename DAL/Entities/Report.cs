using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Report
    {
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateTime { get; set; }

    }
}
