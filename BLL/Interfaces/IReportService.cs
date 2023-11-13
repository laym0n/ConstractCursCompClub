using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Interfaces
{
    public interface IReportService
    {
        List<ReservationsByMonth> ExecuteSP(DateTime param1, DateTime param2);
        List<ReportData> ReportAllReservationsByClient(int idclient);
    }
}
