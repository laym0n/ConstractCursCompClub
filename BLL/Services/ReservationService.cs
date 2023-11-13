﻿using System;
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
        public bool MakeReservation(ReservationModel reservationDto,IAuthorizationService authorizationService)
        {
            ComputerPlaces place = db.Places.GetItem(reservationDto.PlaceID);
            Users curUser = db.Users.GetList().Where(i => i.Id == authorizationService.GetCurrentUser().id).FirstOrDefault();
            if (place==null)
            {
                throw new Exception("Место не найдено");
            }
            decimal totalprice = (reservationDto.EndDateTime - reservationDto.StartDateTime).Hours * place.PricePerHour;
            if (curUser.Balance+curUser.Bonuses < totalprice)
            {
                throw new Exception("Недостаточно баланса");
            }
            Reservations reservation = new Reservations
            {
                PlaceID = place.Id,
                UserID = curUser.Id,
                Id = reservationDto.Id,
                DateTime = reservationDto.DateTime,
                StartDateTime = reservationDto.StartDateTime,
                EndDateTime = reservationDto.EndDateTime,
                ReservationStatus = reservationDto.ReservationStatus,
                TotalPrice = totalprice
            };
            curUser.Balance = curUser.Balance - totalprice;// Минус деньги(((
            db.Reservations.Create(reservation);
            if (db.Save() > 0)
                return true;
            return false;
        }
    }
}
