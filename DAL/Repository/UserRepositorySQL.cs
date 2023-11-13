using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntitiesCodeFirst;
using DAL.Interfaces;
namespace DAL.Repository
{
    public class UserRepositorySQL: IRepository<Users>
    {
        private ComputerClubContext db;

        public UserRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<Users> GetList()
        {
            return db.Users.ToList();
        }
        public Users GetItem(int id)
        {
            return db.Users.Find(id);
        }

        public void Create (Users user)
        {
            db.Users.Add(user);
        }
        public void Update(Users user)
        {
            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            Users user = db.Users.Find(id);
            if(user !=null)
            {
                db.Users.Remove(user);
            }
        }
    }
}
