using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;
using DAL.Interfaces;


namespace DAL.Repository
{
    public class ProcessorRepositorySQL:IRepository<Processor>
    {
        private ComputerClubContext db;

        public ProcessorRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<Processor> GetList()
        {
            return db.Processor.ToList();
        }
        public Processor GetItem(int id)
        {
            return db.Processor.Find(id);
        }

        public void Create(Processor Processor)
        {
            db.Processor.Add(Processor);
        }
        public void Update(Processor Processor)
        {
            db.Entry(Processor).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            Processor Processor = db.Processor.Find(id);
            if (Processor != null)
            {
                db.Processor.Remove(Processor);
            }
        }
    }
}
