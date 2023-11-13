using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ReservationsByMonth
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
    public class ReportData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
