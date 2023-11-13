using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.EntitiesCodeFirst;

namespace DAL.Repository
{
    public class ComputerCompositionRepositorySQL:IRepository<ComputerComposition>
    {
        private ComputerClubContext db;

        public ComputerCompositionRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<ComputerComposition> GetList()
        {
            return db.ComputerComposition.ToList();
        }
        public ComputerComposition GetItem(int id)
        {
            return db.ComputerComposition.Find(id);
        }
   
        public void Create(ComputerComposition computercomposition)
        {
            db.ComputerComposition.Add(computercomposition);
        }
        public void Update(ComputerComposition computercomposition)
        {
            db.Entry(computercomposition).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            ComputerComposition computercomposition = db.ComputerComposition.Find(id);
            if (computercomposition != null)
            {
                db.ComputerComposition.Remove(computercomposition);
            }
        }
    }
}
