﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Interfaces
{
    public interface IReservationService
    {
        bool MakeReservation(ReservationModel reservationDto, IAuthorizationService authorizationservice);
        List<ComputerPlaceModel> CheckFreeComputers(DateTime start, DateTime end);

    }
}
