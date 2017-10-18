using demo_ttnhom.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_ttnhom.Function
{
    class GIAOVIENF
    {
        private MyDbContext context;

        public GIAOVIENF()
        {
            context = new MyDbContext();
        }
        //trả về toàn bộ dữ liệu
        public IQueryable<GIAOVIEN> GIAOVIENs
        {
            get { return context.GIAOVIENs; }
        }

        //trả về 1 đối tượng sản phẩm

        public GIAOVIEN FindEntity(int ID)
        {
            GIAOVIEN dbEntry = context.GIAOVIENs.Find(ID);
            return dbEntry;

        }

        public bool Insert(GIAOVIEN model)
        {
            GIAOVIEN dbEntry = context.GIAOVIENs.Find(model.magv);
            if (dbEntry != null) return false;
            context.GIAOVIENs.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(GIAOVIEN model)
        {
            GIAOVIEN dbEntry = context.GIAOVIENs.Find(model.magv);
            if (dbEntry == null) return false;
            dbEntry.magv = model.magv;
            dbEntry.hoten = model.hoten;
            dbEntry.ngaysinh = model.ngaysinh;
            dbEntry.diachi = model.diachi;
            dbEntry.chucvu = model.chucvu;
            dbEntry.hesoluong = model.hesoluong;
            dbEntry.ghichu = model.ghichu;
            dbEntry.sdt = model.sdt;
            context.SaveChanges();
            return true;
        }

        public bool Delete(GIAOVIEN model)
        {
            GIAOVIEN dbEntry = context.GIAOVIENs.Find(model.magv);
            if (dbEntry == null) return false;
            context.GIAOVIENs.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }

       public  List<GIAOVIEN> Search(string key)
        {
            return new GIAOVIENF().GIAOVIENs.Where(x => x.magv.ToString().Contains(key) || x.hoten.Contains(key) ||
                                                        x.diachi.Contains(key) 
                                                    || x.sdt.Contains(key) || x.chucvu.Contains(key) || x.hesoluong.ToString().Contains(key)).ToList();
        }

    }
}
