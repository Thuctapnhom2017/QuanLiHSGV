namespace demo_ttnhom.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOP")]
    public partial class LOP
    {
        [Key]
        public int malop { get; set; }

        [StringLength(50)]
        public string tenlop { get; set; }

        public int? quanso { get; set; }

        [StringLength(10)]
        public string namhoc { get; set; }
    }
}
