using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using System.ComponentModel;
namespace ConstractCurs.ViewModel
{
    public class ReportViewModel
    {
        private IReportService reportService;

        public ReportViewModel(IReportService reportServ)
        {
            this.reportService = reportServ;
        }
    }
}
