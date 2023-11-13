using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ComputerCompositionModel
    {
        public int Id { get; set; }

        public int? PlaceId { get; set; }

        public int? VideoCardID { get; set; }

        public int? RAMID { get; set; }

        public int? ProcessorID { get; set; }

        public int? HeadphonesID { get; set; }

        public int? KeyboardID { get; set; }

        public int? MouseID { get; set; }

        public int? MonitorID { get; set; }

        public ComputerCompositionModel() { }
        public ComputerCompositionModel(DAL.EntitiesCodeFirst.ComputerComposition comp)
        {
            Id = comp.Id;
            PlaceId = comp.PlaceId;
            VideoCardID = comp.VideoCardID;
            RAMID = comp.RAMID;
            ProcessorID = comp.ProcessorID;
            HeadphonesID = comp.HeadphonesID;
            KeyboardID = comp.KeyboardID;
            MouseID = comp.MouseID;
            MonitorID = comp.MonitorID;
        }
    }
}
