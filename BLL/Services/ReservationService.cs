using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Models;
using DAL.EntitiesCodeFirst;
using DAL.Interfaces;
using BLL;
namespace BLL.Services
{
    public class ReservationService:IReservationService
    {
        private IDbRepos db;
        public ReservationService(IDbRepos repos)
        {
            db = repos;

        }
        public bool MakeReservation(ReservationModel reservationDto)
        {
            ComputerPlaces place = db.Places.GetItem(reservationDto.PlaceID);

            if (place==null)
            {
                throw new Exception("Место не найдено");
            }
            decimal totalprice = (reservationDto.EndDateTime - reservationDto.StartDateTime).Hours * place.PricePerHour;
            Reservations reservation = new Reservations
            {
                PlaceID = place.Id,
                UserID = reservationDto.UserID,
                Id = reservationDto.Id,
                DateTime = reservationDto.DateTime,
                StartDateTime = reservationDto.StartDateTime,
                EndDateTime = reservationDto.EndDateTime,
                ReservationStatus = reservationDto.ReservationStatus,
                TotalPrice = totalprice
            };
            db.Reservations.Create(reservation);
            if (db.Save() > 0)
                return true;
            return false;
        }
    }
}
