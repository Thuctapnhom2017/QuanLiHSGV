using demo_ttnhom.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_ttnhom.Function
{
    class LOPF
    {
        private MyDbContext context;

        public LOPF()
        {
            context = new MyDbContext();
        }
        //trả về toàn bộ dữ liệu
        public IQueryable<LOP> LOPs
        {
            get { return context.LOPs; }
        }

        //trả về 1 đối tượng sản phẩm
        
        public LOP FindEntity(int ID)
        {
            LOP dbEntry = context.LOPs.Find(ID);
            return dbEntry;

        }

        //Thêm
        public bool Insert(LOP model)
        {
            LOP dbEntry = context.LOPs.Find(model.malop);
            if (dbEntry != null) return false;
            context.LOPs.Add(model);
            context.SaveChanges();
            return true;
        }
        //Sửa
        public bool Update(LOP model)
        {
            LOP dbEntry = context.LOPs.Find(model.malop);
            if (dbEntry == null) return false;
            dbEntry.malop = model.malop;
            dbEntry.tenlop = model.tenlop;
            dbEntry.quanso = model.quanso;
            dbEntry.namhoc = model.namhoc;
            // context.Entry(dbEntry).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
            return true;
        }
        //Xóa
        public bool Delete(LOP model)
        {
            LOP dbEntry = context.LOPs.Find(model.malop);
            if (dbEntry == null) return false;
            context.LOPs.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }

        //Tìm kiếm
        public List<LOP> Search(string key)
        {
            return new LOPF().LOPs.Where(x => x.malop.ToString().Contains(key) || x.tenlop.Contains(key) ||  x.quanso.ToString().Contains(key) || x.namhoc.Contains(key)   ).ToList();
        }
    }
}
