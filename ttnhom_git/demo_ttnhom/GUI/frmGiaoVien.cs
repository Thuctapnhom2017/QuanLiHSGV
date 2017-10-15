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
using demo_ttnhom.EF;

namespace demo_ttnhom.GUI
{
    public partial class frmGiaoVien : DevExpress.XtraEditors.XtraForm
    {
        public frmGiaoVien()
        {
            InitializeComponent();
            Init_();
            Bindingtxt();
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


        private void Init_()
        {
            BindingSource source = new BindingSource();
            source.DataSource = new GIAOVIENF().GIAOVIENs.ToList();
            GridGV.DataSource = source;
        }
        private void Bindingtxt()
        {
            txtMaGV.DataBindings.Add(new Binding("Text", GridGV.DataSource, "magv", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", GridGV.DataSource, "hoten", true, DataSourceUpdateMode.Never));
            dateNS.DataBindings.Add(new Binding("Text", GridGV.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", GridGV.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            txtDienThoai.DataBindings.Add(new Binding("Text", GridGV.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            txtChucVu.DataBindings.Add(new Binding("Text", GridGV.DataSource, "chucvu", true, DataSourceUpdateMode.Never));
            txtHSL.DataBindings.Add(new Binding("Text", GridGV.DataSource, "hesoluong", true, DataSourceUpdateMode.Never));
            txtGhiChu.DataBindings.Add(new Binding("Text", GridGV.DataSource, "ghichu", true, DataSourceUpdateMode.Never));

        }
        private void clear()
        {
            txtGhiChu.Text = txtHoTen.Text = txtDiaChi.Text = txtDienThoai.Text = txtChucVu.Text = txtHSL.Text = txtGhiChu.Text = txtMaGV.Text = "";
        }
        private void ClearBinding()
        {
            txtMaGV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            dateNS.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtChucVu.DataBindings.Clear();
            txtHSL.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                GIAOVIEN model = new GIAOVIEN()
                {
                    hoten = txtHoTen.Text,
                    ngaysinh = Convert.ToDateTime(dateNS.Text),
                    diachi = txtDiaChi.Text,
                    sdt = txtDienThoai.Text,
                    chucvu = txtChucVu.Text,
                    hesoluong = Convert.ToDecimal(txtHSL.Text),
                    ghichu = txtGhiChu.Text

                };

                int ID_ = -1;
                if (txtMaGV.Text != "") ID_ = int.Parse(txtMaGV.Text.ToString());
                model.magv = ID_;

                if (txtMaGV.Text == "")
                {
                    var result = new GIAOVIENF().Insert(model);
                    if (result) MessageBox.Show("Done"); else MessageBox.Show("Lỗi");
                }
                else
                {
                    var result = new GIAOVIENF().Update(model);
                    if (result) MessageBox.Show("Done"); else MessageBox.Show("Lỗi");
                }
                Init_(); ClearBinding(); Bindingtxt();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà cung cấp " + txtHoTen.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var ans = new GIAOVIENF().Delete(new GIAOVIEN { magv = int.Parse(txtMaGV.Text) });
                    Init_(); ClearBinding(); Bindingtxt();
                }
            }
            catch { }
        }

        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            GridGV.DataSource = new GIAOVIENF().Search(txtTimKiem.Text);
            ClearBinding(); Bindingtxt();
        }
    }
}