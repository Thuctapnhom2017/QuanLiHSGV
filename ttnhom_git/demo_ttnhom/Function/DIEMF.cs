using demo_ttnhom.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_ttnhom.Function
{
    class DIEMF
    {
        private MyDbContext context;

        public DIEMF()
        {
            context = new MyDbContext();
        }
        //trả về toàn bộ dữ liệu
        public IQueryable<DIEM> DIEMs
        {
            get { return context.DIEMs; }
        }

        //trả về 1 đối tượng điểm

        public DIEM FindEntity(int ID)
        {
            DIEM dbEntry = context.DIEMs.Find(ID);
            return dbEntry;

        }

        public bool Insert(DIEM model)
        {
            DIEM dbEntry = context.DIEMs.Find(model.ID);
            if (dbEntry != null) return false;
            context.DIEMs.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(DIEM model)
        {
            DIEM dbEntry = context.DIEMs.Find(model.ID);
            if (dbEntry == null) return false;
            dbEntry.mahs = model.mahs;
            dbEntry.mamon = model.mamon;
            dbEntry.diemtb = model.diemtb;
            dbEntry.hanhkiem = model.hanhkiem;
            dbEntry.hocki = model.hocki;
            dbEntry.namhoc = model.namhoc;
            context.SaveChanges();
            return true;
        }

        public bool Delete(DIEM model)
        {
            DIEM dbEntry = context.DIEMs.Find(model.ID);
            if (dbEntry == null) return false;
            context.DIEMs.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }
        public DIEM FindDiem(int hocki, string namhoc, int mahs, int mamon)
        {
            var query = from x in context.DIEMs
                        where x.hocki == hocki && x.namhoc == namhoc && x.mahs == mahs && x.mamon == mamon
                        select x;

            List<DIEM> ans = query.ToList();
            return ans.FirstOrDefault();
        }
    }
}
