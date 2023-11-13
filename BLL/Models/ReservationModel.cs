using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ReservationModel
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public int PlaceID { get; set; }

        public DateTime DateTime { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }
        public string ReservationStatus { get; set; }
        public decimal TotalPrice { get; set; }
        
        public ReservationModel() { }
        public ReservationModel(DAL.EntitiesCodeFirst.Reservations res)
        {
            Id = res.Id;
            UserID = res.UserID;
            PlaceID = res.PlaceID;
            DateTime = res.DateTime;
            StartDateTime = res.StartDateTime;
            EndDateTime = res.EndDateTime;
            ReservationStatus = res.ReservationStatus;
            TotalPrice = res.TotalPrice;
        }
    }
}
