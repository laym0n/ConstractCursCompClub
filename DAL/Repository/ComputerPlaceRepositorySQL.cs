using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class ComputerPlacesRepositorySQL:IRepository<ComputerPlaces>
    {
        private ComputerClubContext db;

        public ComputerPlacesRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<ComputerPlaces> GetList()
        {
            return db.ComputerPlaces.ToList();
        }
        public ComputerPlaces GetItem(int id)
        {
            return db.ComputerPlaces.Find(id);
        }

        public void Create(ComputerPlaces ComputerPlaces)
        {
            db.ComputerPlaces.Add(ComputerPlaces);
        }
        public void Update(ComputerPlaces ComputerPlaces)
        {
            db.Entry(ComputerPlaces).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            ComputerPlaces ComputerPlaces = db.ComputerPlaces.Find(id);
            if (ComputerPlaces != null)
            {
                db.ComputerPlaces.Remove(ComputerPlaces);
            }
        }
    }
}