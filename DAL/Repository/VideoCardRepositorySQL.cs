using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.EntitiesCodeFirst;

namespace DAL.Repository
{
    public class VideoCardRepositorySQL:IRepository<VideoCard>

    {
        private ComputerClubContext db;

        public VideoCardRepositorySQL(ComputerClubContext dbcontext)
        {
            this.db = dbcontext;
        }
        public List<VideoCard> GetList()
        {
            return db.VideoCard.ToList();
        }
        public VideoCard GetItem(int id)
        {
            return db.VideoCard.Find(id);
        }

        public void Create(VideoCard VideoCard)
        {
            db.VideoCard.Add(VideoCard);
        }
        public void Update(VideoCard VideoCard)
        {
            db.Entry(VideoCard).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            VideoCard VideoCard = db.VideoCard.Find(id);
            if (VideoCard != null)
            {
                db.VideoCard.Remove(VideoCard);
            }
        }

    }
}
