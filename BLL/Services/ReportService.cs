using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;


namespace BLL.Services
{
    public class ReportService:IReportService
    {
        private IDbRepos db;
        public ReportService(IDbRepos repos)
        {
            db = repos;
        }
        public List<ReservationsByMonth> ExecuteSP(DateTime param1, DateTime param2)
        {
            return db.Report.ExecuteSP(param1, param2).Select(i => new OrdersByMonth { fio = i.fio, Date = i.Date, TotalPrice = i.TotalPrice }).ToList();
        }

        public List<ReportData> ReportAllOrdersbyClient(int idclient)
        {
            var request = db.Reports.ReportAllOrdersbyClient(idclient)
                .Select(i => new ReportData() { fio = i.fio, TotalPrice = i.TotalPrice, Date = i.Date }).ToList();
            return request;
        }
    }
}
