using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ComputerPlaceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public decimal PricePerHour { get; set; }
        public ComputerPlaceModel() { }
        public ComputerPlaceModel(DAL.EntitiesCodeFirst.ComputerPlaces place)
        {
            Id = place.Id;
            Name = place.Name;
            Status = place.Status;
            PricePerHour = place.PricePerHour;
        }
    }
}
