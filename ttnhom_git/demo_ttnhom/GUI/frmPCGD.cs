using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using demo_ttnhom.Function;
using DevExpress.XtraGrid.Views.Grid;
using demo_ttnhom.EF;

namespace demo_ttnhom.GUI
{
    public partial class frmPCGD : DevExpress.XtraEditors.XtraForm
    {
        public frmPCGD()
        {
            InitializeComponent();
            
            
            Init_cb();
            Init_Grid();
            _Bindingtxt();
            clearBinding();
            for (int i = 1980; i <= 2030; i++) { cbNamHoc.Items.Add(string.Format(i + "-" + (i + 1).ToString())); }
            PhanQuyen();
        }
        private void PhanQuyen()
        {
            if (Constant.NGUOIDUNG_ != null)
            {
                if (Constant.NGUOIDUNG_.Admin == true)
                {
                    btnLuu.Enabled = btnXoa.Enabled = btnThem.Enabled = true;
                }
                else
                {
                    btnLuu.Enabled = btnXoa.Enabled = btnThem.Enabled = false;
                }
            }
            else
            {

            }
        }
        public void Init_cb()
        {

            lueLop.Properties.DataSource = new LOPF().LOPs.ToList();
            lueLop.Properties.DisplayMember = "tenlop";
            lueLop.Properties.ValueMember = "malop";
            lueLop.Properties.ForceInitialize();
            //lueLop.Properties.PopulateColumns();
            lueLop.ItemIndex = 0;
            lueLop.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("malop", 50, "Mã Lớp"));
            lueLop.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenlop", 100, "Tên Lớp"));
            lueLop.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("namhoc", 75, "Năm Học"));

            cbMonHoc.DataSource = new MONHOCF().MONHOCs.ToList();
            cbMonHoc.DisplayMember = "tenmon"; 
            cbMonHoc.ValueMember="ID";

            cbGV.DataSource = new GIAOVIENF().GIAOVIENs.ToList();
            cbGV.DisplayMember = "hoten";
            cbGV.ValueMember = "magv";
            cbGV.SelectedValue=new GIANGDAYF().FindLop(int.Parse(lueLop.EditValue.ToString()), int.Parse(cbMonHoc.SelectedValue.ToString())).magv;

            lueHS.Properties.DataSource = new HOCSINHF().HOCSINHs.ToList();
            lueHS.Properties.DisplayMember = "hoten";
            lueHS.Properties.ValueMember = "mahs";
            lueHS.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("mahs",75 ,"Mã Học Sinh"));
            lueHS.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("hoten",200, "Họ Tên Học Sinh"));
            lueHS.Properties.NullText = "Thêm học sinh vào lớp ";

        }
        public void Init_Grid()
        {
            int var = int.Parse(lueLop.EditValue.ToString());
            GridHS.DataSource = new HOCSINHF().HOCSINHs.Where(x => x.malop ==var).ToList();
        }
        public void _Bindingtxt()
        {
            
            cbNamHoc.DataBindings.Add(new Binding("Text", GridHS.DataSource, "namhoc", true, DataSourceUpdateMode.Never));
            cbHK.DataBindings.Add(new Binding("Text", GridHS.DataSource, "hocki", true, DataSourceUpdateMode.Never));
            txtDiem.DataBindings.Add(new Binding("Text", GridHS.DataSource, "diemtb", true, DataSourceUpdateMode.Never));
            txtHanhKiem.DataBindings.Add(new Binding("Text", GridHS.DataSource, "hanhkiem", true, DataSourceUpdateMode.Never));
        }
        public void clearBinding()
        {
            cbNamHoc.DataBindings.Clear();
            cbHK.DataBindings.Clear();
            txtDiem.DataBindings.Clear();
            txtHanhKiem.DataBindings.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            try
            {
                int[] selRows = ((GridView)GridHS.MainView).GetSelectedRows();
                HOCSINH hs = (HOCSINH)(((GridView)GridHS.MainView).GetRow(selRows[0]));
                DialogResult result = MessageBox.Show("Bạn có muốn xóa học sinh " +hs.hoten + " khỏi lớp " +lueLop.Text+" không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (hs != null)
                    {
                        hs.malop = null;
                        bool ans = new HOCSINHF().Update(hs);
                        Init_Grid();
                    }
                }
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HOCSINH hs = new HOCSINHF().FindEntity(int.Parse(lueHS.EditValue.ToString()));
                if(hs!=null)
                {
                    hs.malop = int.Parse(lueLop.EditValue.ToString());
                    new HOCSINHF().Update(hs);
                    Init_Grid();
                }
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                GIANGDAY model = new GIANGDAYF().FindLop(int.Parse(lueLop.EditValue.ToString()),int.Parse(cbMonHoc.SelectedValue.ToString()));
                if (model != null)
                {
                    model.magv = int.Parse(cbGV.SelectedValue.ToString());
                    new GIANGDAYF().Update(model);
                    Init_Grid();
                }
            }
            catch { }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selRows = ((GridView)GridHS.MainView).GetSelectedRows();
                HOCSINH hs = (HOCSINH)(((GridView)GridHS.MainView).GetRow(selRows[0]));
                DIEM result = new DIEMF().FindDiem(int.Parse(cbHK.Text), cbNamHoc.Text, hs.mahs, int.Parse(cbMonHoc.SelectedValue.ToString()));
                if (result != null)
                {
                    txtDiem.Text = result.diemtb.ToString();
                    txtHanhKiem.Text = result.hanhkiem;
                }
                else
                {
                    txtDiem.Text = txtHanhKiem.Text = "";
                }
            }
            catch { txtDiem.Text = txtHanhKiem.Text = ""; }
            
        }

        private void lueLop_EditValueChanged(object sender, EventArgs e)
        {
            try { Init_Grid(); } catch { }
            
        }
    }
}