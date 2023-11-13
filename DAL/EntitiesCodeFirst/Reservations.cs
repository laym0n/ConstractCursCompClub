namespace DAL.EntitiesCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservations
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public int PlaceID { get; set; }

        public DateTime DateTime { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }
        public decimal TotalPrice { get; set; }

        [StringLength(20)]
        public string ReservationStatus { get; set; }

        public virtual ComputerPlaces ComputerPlaces { get; set; }

        public virtual Users Users { get; set; }
    }
}
