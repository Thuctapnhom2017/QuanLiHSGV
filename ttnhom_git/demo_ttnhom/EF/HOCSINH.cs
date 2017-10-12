namespace demo_ttnhom.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCSINH")]
    public partial class HOCSINH
    {
        [Key]
        public int mahs { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        public int? malop { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(20)]
        public string sdt { get; set; }

        [StringLength(50)]
        public string hotencha { get; set; }

        [StringLength(50)]
        public string hotenme { get; set; }
    }
}
