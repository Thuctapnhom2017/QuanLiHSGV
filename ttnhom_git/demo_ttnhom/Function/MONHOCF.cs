using demo_ttnhom.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_ttnhom.Function
{
    class MONHOCF
    {
        private MyDbContext context;

        public MONHOCF()
        {
            context = new MyDbContext();
        }
        //trả về toàn bộ dữ liệu
        public IQueryable<MONHOC> MONHOCs
        {
            get { return context.MONHOCs; }
        }

        //trả về 1 đối tượng sản phẩm

        public MONHOC FindEntity(int ID)
        {
            MONHOC dbEntry = context.MONHOCs.Find(ID);
            return dbEntry;

        }
        //Thêm
        public bool Insert(MONHOC model)
        {
            MONHOC dbEntry = context.MONHOCs.Find(model.ID);
            if (dbEntry != null) return false;
            context.MONHOCs.Add(model);
            context.SaveChanges();
            return true;
        }
        //Sửa
        public bool Update(MONHOC model)
        {
            MONHOC dbEntry = context.MONHOCs.Find(model.ID);
            if (dbEntry == null) return false;
            dbEntry.tenmon = model.tenmon;
            context.SaveChanges();
            return true;
        }
        //Xóa
        public bool Delete(MONHOC model)
        {
            MONHOC dbEntry = context.MONHOCs.Find(model.ID);
            if (dbEntry == null) return false;
            context.MONHOCs.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }
        public List<MONHOC> Search(string key)
        {
            return new MONHOCF().MONHOCs.Where(x => x.ID.ToString().Contains(key) || x.tenmon.Contains(key) || x.note.Contains(key) ).ToList();
        }
    }
}
