using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class KeyboardRepositorySQL:IRepository<Keyboard>
    {
        private ComputerClubContext db;

        public KeyboardRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<Keyboard> GetList()
        {
            return db.Keyboard.ToList();
        }
        public Keyboard GetItem(int id)
        {
            return db.Keyboard.Find(id);
        }

        public void Create(Keyboard Keyboard)
        {
            db.Keyboard.Add(Keyboard);
        }
        public void Update(Keyboard Keyboard)
        {
            db.Entry(Keyboard).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            Keyboard Keyboard = db.Keyboard.Find(id);
            if (Keyboard != null)
            {
                db.Keyboard.Remove(Keyboard);
            }
        }
    }
}
