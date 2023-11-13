namespace DAL.EntitiesCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComputerComposition")]
    public partial class ComputerComposition
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

        public virtual Headphones Headphones { get; set; }

        public virtual Keyboard Keyboard { get; set; }

        public virtual Mouse Mouse { get; set; }

        public virtual ComputerPlaces ComputerPlaces { get; set; }

        public virtual Processor Processor { get; set; }

        public virtual RAM RAM { get; set; }

        public virtual VideoCard VideoCard { get; set; }

        public virtual Monitor Monitor { get; set; }
    }
}
