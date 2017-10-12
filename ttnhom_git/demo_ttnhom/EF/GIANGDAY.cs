namespace demo_ttnhom.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIANGDAY")]
    public partial class GIANGDAY
    {
        [Key]
        public int magd { get; set; }

        public int? malop { get; set; }

        public int? magv { get; set; }

        [StringLength(20)]
        public string namhoc { get; set; }

        public int? monhoc { get; set; }
    }
}
