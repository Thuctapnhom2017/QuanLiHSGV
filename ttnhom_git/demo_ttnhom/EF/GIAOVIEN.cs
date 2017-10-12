namespace demo_ttnhom.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAOVIEN")]
    public partial class GIAOVIEN
    {
        [Key]
        public int magv { get; set; }

        [Required]
        [StringLength(50)]
        public string hoten { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(20)]
        public string sdt { get; set; }

        [StringLength(50)]
        public string chucvu { get; set; }

        public decimal? hesoluong { get; set; }

        [StringLength(100)]
        public string ghichu { get; set; }
    }
}
