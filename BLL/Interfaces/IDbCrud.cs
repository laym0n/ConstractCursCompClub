using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Models; 
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDbCrud
    {
        List<ComputerPlaceModel> GetAllPlaces();
        List<ReservationModel> GetAllReservations();
        ComputerCompositionModel GetComp(int compId);
        List<ComputerCompositionModel> GetAllComps();
        void CreateComp(ComputerCompositionModel c);
        void UpdateComp(ComputerCompositionModel c);
        void DeleteComp(int id);
        ReservationModel GetReservation(int id);
        List<MonitorModel> GetAllMonitors();
        List<KeyboardModel> GetAllKeyboards();
        List<VideoCardModel> GetAllVideocards();
        List<HeadphonesModel> GetAllHeadphones();
        List<UserModel> GetAllUsers();

    }
}
