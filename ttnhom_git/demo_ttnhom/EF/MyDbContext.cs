namespace demo_ttnhom.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        public virtual DbSet<DIEM> DIEMs { get; set; }
        public virtual DbSet<GIANGDAY> GIANGDAYs { get; set; }
        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<HOCSINH> HOCSINHs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DIEM>()
            //    .Property(e => e.mamon)
            //    .IsFixedLength();

            modelBuilder.Entity<DIEM>()
                .Property(e => e.diemtb)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.namhoc)
                .IsUnicode(false);

            modelBuilder.Entity<GIANGDAY>()
                .Property(e => e.namhoc)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.namhoc)
                .IsFixedLength();
        }
    }
}
