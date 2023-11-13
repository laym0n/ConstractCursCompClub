using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class MouseRepositorySQL:IRepository<Mouse>
    {
        private ComputerClubContext db;

        public MouseRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<Mouse> GetList()
        {
            return db.Mouse.ToList();
        }
        public Mouse GetItem(int id)
        {
            return db.Mouse.Find(id);
        }

        public void Create(Mouse Mouse)
        {
            db.Mouse.Add(Mouse);
        }
        public void Update(Mouse Mouse)
        {
            db.Entry(Mouse).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            Mouse Mouse = db.Mouse.Find(id);
            if (Mouse != null)
            {
                db.Mouse.Remove(Mouse);
            }
        }
    }
}

