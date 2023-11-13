using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class HeadphonesRepositorySQL:IRepository<Headphones>
    {
        private ComputerClubContext db;

        public HeadphonesRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<Headphones> GetList()
        {
            return db.Headphones.ToList();
        }
        public Headphones GetItem(int id)
        {
            return db.Headphones.Find(id);
        }

        public void Create(Headphones Headphones)
        {
            db.Headphones.Add(Headphones);
        }
        public void Update(Headphones Headphones)
        {
            db.Entry(Headphones).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            Headphones Headphones = db.Headphones.Find(id);
            if (Headphones != null)
            {
                db.Headphones.Remove(Headphones);
            }
        }
    }
}
