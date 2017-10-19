using demo_ttnhom.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_ttnhom.Function
{
    class NGUOIDUNGF
    {
        private MyDbContext context;
        public NGUOIDUNGF()
        {
            context = new MyDbContext();
        }
        //trả về toàn bộ dữ liệu
        public IQueryable<NGUOIDUNG> NGUOIDUNGs
        {
            get { return context.NGUOIDUNGs; }
        }

        //trả về 1 đối tượng sản phẩm

        public NGUOIDUNG FindEntity(string ID)
        {
            NGUOIDUNG dbEntry = context.NGUOIDUNGs.Find(ID);
            return dbEntry;

        }

        public bool Insert(NGUOIDUNG model)
        {
            NGUOIDUNG dbEntry = context.NGUOIDUNGs.Find(model.UserName);
            if (dbEntry != null) return false;
            context.NGUOIDUNGs.Add(model);
            context.SaveChanges();
            return true;
        }

        public bool Update(NGUOIDUNG model)
        {
            NGUOIDUNG dbEntry = context.NGUOIDUNGs.Find(model.UserName);
            if (dbEntry == null) return false;
            dbEntry.UserName = model.UserName;
            dbEntry.PassWord = model.PassWord;
            dbEntry.Admin = model.Admin;
            context.SaveChanges();
            return true;
        }

        public bool Delete(NGUOIDUNG model)
        {
            NGUOIDUNG dbEntry = context.NGUOIDUNGs.Find(model.UserName);
            if (dbEntry == null) return false;
            context.NGUOIDUNGs.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }

        public int Login(string username, string password)
        {
            var result = context.NGUOIDUNGs.Where(x => x.UserName.Equals(username) && x.PassWord.Equals(password)).FirstOrDefault();
            if (result != null)
            {
                var ans = new NGUOIDUNGF().FindEntity(username).Admin.GetValueOrDefault(false);
                if (ans) return 1;
                return 0;
            }
            return -1;
        }
        public List<NGUOIDUNG> Search(string key)
        {
            return new NGUOIDUNGF().NGUOIDUNGs.Where(x => x.UserName.Contains(key) || x.PassWord.Contains(key)).ToList();
        }
    }
}
