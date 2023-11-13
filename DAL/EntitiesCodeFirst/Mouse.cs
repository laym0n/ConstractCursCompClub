namespace DAL.EntitiesCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mouse")]
    public partial class Mouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mouse()
        {
            ComputerComposition = new HashSet<ComputerComposition>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Specifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComputerComposition> ComputerComposition { get; set; }
    }
}
