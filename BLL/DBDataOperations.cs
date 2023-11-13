using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL.Interfaces;
using BLL.Models;
using DAL.EntitiesCodeFirst;
namespace BLL
{
    public class DBDataOperations:IDbCrud
    {
        IDbRepos db;
        public DBDataOperations(IDbRepos repos)
        {
            db = repos;
        }
        public List<ComputerCompositionModel> GetAllComps()
        {
            return db.ComputerCompositions.GetList().Select(i => new ComputerCompositionModel(i)).ToList();
        }
        public List<ReservationModel> GetAllReservations()
        {
            return db.Reservations.GetList().Select(i => new ReservationModel(i)).ToList();
        }
        public bool Save()
        {
            if (db.Save() > 0) return true;
            return false;
        }
        public ComputerCompositionModel GetComp(int id)
        {
            return new ComputerCompositionModel(db.ComputerCompositions.GetItem(id));
        }
        public ReservationModel GetReservation(int id)
        {
            return new ReservationModel(db.Reservations.GetItem(id));
        }
        public void DeleteComp(int id)
        {
            ComputerComposition comp = db.ComputerCompositions.GetItem(id);
            if(comp!=null)
            {
                db.ComputerCompositions.Delete(comp.Id);
                Save();
            }
        }
        public void CreateComp(ComputerCompositionModel c)
        {
            db.ComputerCompositions.Create(new ComputerComposition()
            {
                PlaceId = c.PlaceId,
                VideoCardID = c.VideoCardID,
                RAMID = c.RAMID,
                ProcessorID = c.ProcessorID,
                HeadphonesID = c.HeadphonesID,
                KeyboardID = c.KeyboardID,
                MouseID = c.MouseID,
                MonitorID = c.MonitorID
            });
            Save();
        }
        public void UpdateComp(ComputerCompositionModel c)
        {
            ComputerComposition comp = db.ComputerCompositions.GetItem(c.Id);
            comp.PlaceId = c.PlaceId;
            comp.VideoCardID = c.VideoCardID;
            comp.RAMID = c.RAMID;
            comp.ProcessorID = c.ProcessorID;
            comp.HeadphonesID = c.HeadphonesID;
            comp.KeyboardID = c.KeyboardID;
            comp.MouseID = c.MouseID;
            comp.MonitorID = c.MonitorID;
            db.ComputerCompositions.Update(comp);
            Save();

        }
        public List<ComputerPlaceModel> GetAllPlaces()
        {
            return db.Places.GetList().Select(i => new ComputerPlaceModel(i)).ToList();
        }
        public List<MonitorModel> GetAllMonitors()
        {
            return db.Monitors.GetList().Select(i => new MonitorModel(i)).ToList();
        }
        public List<KeyboardModel> GetAllKeyboards()
        {
            return db.Keyboards.GetList().Select(i => new KeyboardModel(i)).ToList();
        }
        public List<VideoCardModel>GetAllVideocards()
        {
            return db.VideoCards.GetList().Select(i => new VideoCardModel(i)).ToList();
        }
        public List<HeadphonesModel> GetAllHeadphones()
        {
            return db.Headphones.GetList().Select(i => new HeadphonesModel(i)).ToList();
        }
        public List<UserModel> GetAllUsers()
        {
            return db.Users.GetList().Select(i => new UserModel(i)).ToList();
        }
    }
}
