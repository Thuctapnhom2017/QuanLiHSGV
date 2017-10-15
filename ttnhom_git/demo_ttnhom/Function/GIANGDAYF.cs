using demo_ttnhom.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_ttnhom.Function
{
    class GIANGDAYF
    {
        private MyDbContext context;

        public GIANGDAYF()
        {
            context = new MyDbContext();
        }
        //trả về toàn bộ dữ liệu
        public IQueryable<GIANGDAY> GIANGDAYs
        {
            get { return context.GIANGDAYs; }
        }

        //trả về 1 đối tượng giảng dạy

        public GIANGDAY FindEntity(int ID)
        {
            GIANGDAY dbEntry = context.GIANGDAYs.Find(ID);
            return dbEntry;

        }
        public GIANGDAY FindLop(int malop, int monhoc)
        {
            var dbEntry = context.GIANGDAYs.Where(x => x.malop == malop && x.monhoc == monhoc).FirstOrDefault();
            if (dbEntry != null)
                return (GIANGDAY)dbEntry;
            return new GIANGDAY();

        }

        public bool Insert(GIANGDAY model)
        {
            GIANGDAY dbEntry = context.GIANGDAYs.Find(model.magd);
            if (dbEntry != null) return false;
            context.GIANGDAYs.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(GIANGDAY model)
        {
            GIANGDAY dbEntry = context.GIANGDAYs.Find(model.magd);
            if (dbEntry == null) return false;
            dbEntry.magv = model.magv;
            dbEntry.magd = model.magd;
            dbEntry.malop = model.malop;
            dbEntry.monhoc = model.monhoc;
            context.SaveChanges();
            return true;
        }

        public bool Delete(GIANGDAY model)
        {
            GIANGDAY dbEntry = context.GIANGDAYs.Find(model.magd);
            if (dbEntry == null) return false;
            context.GIANGDAYs.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }

    }
}
