namespace demo_ttnhom.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONHOC")]
    public partial class MONHOC
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string tenmon { get; set; }

        [StringLength(500)]
        public string note { get; set; }
    }
}
