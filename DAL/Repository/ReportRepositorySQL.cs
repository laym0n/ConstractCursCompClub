/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.EntitiesCodeFirst;
using System.Data.Entity;
using System.Data.SqlClient;
using DAL.Entities;

namespace DAL.Repository
{
    public class ReportRepositorySQL : IReportsRepository
    {
        private ComputerClubContext db;
        public ReportRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Report> ReportReservationByMouth(DateTime from, DateTime to)
        {
            Report report = new Report();
            report.DateTime = db.Database

        }


        *//*public List<Report> ExecuteSP(DateTime from, DateTime to)
        {
            SqlParameter date1 = new SqlParameter("@data1", param1);
            SqlParameter date2 = new SqlParameter("@data2", param2);

            var result = db.Data
                *//*Database.SqlQuery<SPResult>("order2 @data1,@data2", new object[] { date1, date2 }).ToList();*//*
            var data = result.GroupBy(i => new { i.fio, i.Date }).ToDictionary(i => i.Key, i => i.Select(j => j.Totalprice))
                .Select(i => new OrdersByMonth
                {
                    fio = i.Key.fio,
                    Date = i.Key.Date,
                    TotalPrice = String.Join(",", i.Value.Select(j => j).ToArray())
                }).ToList();

            return d*//*
        }
        public List<Report> ReportAllOrdersbyClient(int idclient)
        {
            var request = db.zakaz
            .Join(db.client, z => z.id_client, cl => cl.id_client, (z, cl) => new { z, cl })
            .Where(i => i.z.id_client == idclient)
            .Select(i => new Report() { fio = i.cl.fio, TotalPrice = i.z.totalprice, Date = i.z.date }).ToList();
            return request;
        }
    }
}
*/