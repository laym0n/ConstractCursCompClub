using System;
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
        private IDbRepos db;
        private class SPResult
        {
            public string fio { get; set; }
            public DateTime Date { get; set; }
            public decimal Totalprice { get; set; }
        }
        public ReportRepositorySQL(Model1 dbcontext)
        {
            this.db = dbcontext;
        }
        public List<OrdersByMonth> ExecuteSP(DateTime param1, DateTime param2)
        {
            SqlParameter date1 = new SqlParameter("@data1", param1);
            SqlParameter date2 = new SqlParameter("@data2", param2);

            var result = db.Database.SqlQuery<SPResult>("order2 @data1,@data2", new object[] { date1, date2 }).ToList();
            var data = result.GroupBy(i => new { i.fio, i.Date }).ToDictionary(i => i.Key, i => i.Select(j => j.Totalprice))
                .Select(i => new OrdersByMonth
                {
                    fio = i.Key.fio,
                    Date = i.Key.Date,
                    TotalPrice = String.Join(",", i.Value.Select(j => j).ToArray())
                }).ToList();

            return data;
        }
        public List<ReportData> ReportAllOrdersbyClient(int idclient)
        {
            var request = db.zakaz
            .Join(db.client, z => z.id_client, cl => cl.id_client, (z, cl) => new { z, cl })
            .Where(i => i.z.id_client == idclient)
            .Select(i => new ReportData() { fio = i.cl.fio, TotalPrice = i.z.totalprice, Date = i.z.date }).ToList();
            return request;
        }
    }
}
