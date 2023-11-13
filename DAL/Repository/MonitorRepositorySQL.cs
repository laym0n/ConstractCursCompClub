using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class MonitorRepositorySQL:IRepository<Monitor>

    {
        private ComputerClubContext db;

        public MonitorRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<Monitor> GetList()
        {
            return db.Monitor.ToList();
        }
        public Monitor GetItem(int id)
        {
            return db.Monitor.Find(id);
        }

        public void Create(Monitor Monitor)
        {
            db.Monitor.Add(Monitor);
        }
        public void Update(Monitor Monitor)
        {
            db.Entry(Monitor).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            Monitor Monitor = db.Monitor.Find(id);
            if (Monitor != null)
            {
                db.Monitor.Remove(Monitor);
            }
        }
    }
}
