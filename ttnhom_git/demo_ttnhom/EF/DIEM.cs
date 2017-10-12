namespace demo_ttnhom.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIEM")]
    public partial class DIEM
    {
        public int ID { get; set; }

        public int mahs { get; set; }

        public int mamon { get; set; }

        public decimal? diemtb { get; set; }

        [StringLength(50)]
        public string hanhkiem { get; set; }

        public int? hocki { get; set; }

        [StringLength(20)]
        public string namhoc { get; set; }
    }
}
