using demo_ttnhom.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_ttnhom.Function
{
    class HOCSINHF
    {
        private MyDbContext context;

        public HOCSINHF()
        {
            context = new MyDbContext();
        }
        //trả về toàn bộ dữ liệu
        public IQueryable<HOCSINH> HOCSINHs
        {
            get { return context.HOCSINHs; }
        }

        //trả về 1 đối tượng sản phẩm

        public HOCSINH FindEntity(int ID)
        {
            HOCSINH dbEntry = context.HOCSINHs.Find(ID);
            return dbEntry;

        }

        public bool Insert(HOCSINH model)
        {
            HOCSINH dbEntry = context.HOCSINHs.Find(model.mahs);
            if (dbEntry != null) return false;
            context.HOCSINHs.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(HOCSINH model)
        {
            HOCSINH dbEntry = context.HOCSINHs.Find(model.mahs);
            if (dbEntry == null) return false;
            dbEntry.mahs = model.mahs;
            dbEntry.hoten = model.hoten;
            dbEntry.malop = model.malop;
            dbEntry.ngaysinh = model.ngaysinh;
            dbEntry.diachi = model.diachi;
            dbEntry.sdt = model.sdt;
            dbEntry.hotencha = model.hotencha;
            dbEntry.hotenme = model.hotenme;
            // context.Entry(dbEntry).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
            return true;
        }

        public bool Delete(HOCSINH model)
        {
            HOCSINH dbEntry = context.HOCSINHs.Find(model.mahs);
            if (dbEntry == null) return false;
            //context.Entry(model).State = System.Data.Entity.EntityState.Deleted;
            context.HOCSINHs.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }
        public List<HOCSINH> Search(string key)
        {
            return new HOCSINHF().HOCSINHs.Where(x => x.mahs.ToString().Contains(key) || x.hoten.Contains(key) ||// x.ngaysinh.GetValueOrDefault(DateTime.Now).ToString("dd/MM/yyyy").Contains(key) ||
                                                        x.diachi.Contains(key)
                                                    || x.sdt.Contains(key) || x.malop.ToString().Contains(key)|| x.hotencha.Contains(key) || x.hotenme.Contains(key)).ToList();
        }
    }
}
