using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;
using DAL.Interfaces;

namespace DAL.Repository
{
   public class ReservationsRepositorySQL:IRepository<Reservations>
    {
        private ComputerClubContext db;

        public ReservationsRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<Reservations> GetList()
        {
            return db.Reservations.ToList();
        }
        public Reservations GetItem(int id)
        {
            return db.Reservations.Find(id);
        }

        public void Create(Reservations Reservations)
        {
            db.Reservations.Add(Reservations);
        }
        public void Update(Reservations Reservations)
        {
            db.Entry(Reservations).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            Reservations Reservations = db.Reservations.Find(id);
            if (Reservations != null)
            {
                db.Reservations.Remove(Reservations);
            }
        }
    }
}
