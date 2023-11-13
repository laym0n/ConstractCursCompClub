using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;
using DAL.Interfaces;
namespace DAL.Repository
{
    public class RAMRepositorySQL:IRepository<RAM>

    {
        private ComputerClubContext db;

        public RAMRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<RAM> GetList()
        {
            return db.RAM.ToList();
        }
        public RAM GetItem(int id)
        {
            return db.RAM.Find(id);
        }

        public void Create(RAM RAM)
        {
            db.RAM.Add(RAM);
        }
        public void Update(RAM RAM)
        {
            db.Entry(RAM).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            RAM RAM = db.RAM.Find(id);
            if (RAM != null)
            {
                db.RAM.Remove(RAM);
            }
        }
    }
}
