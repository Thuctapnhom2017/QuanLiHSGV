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
    public partial class frmHocSinh : DevExpress.XtraEditors.XtraForm
    {
        public frmHocSinh()
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
            cbLop.DataSource = new LOPF().LOPs.ToList();
            cbLop.DisplayMember = "tenlop";
            cbLop.ValueMember = "malop";
            BindingSource source = new BindingSource();
            source.DataSource = new HOCSINHF().HOCSINHs.ToList();
            GridHocSinh.DataSource = source;
        }
        private void Bindingtxt()
        {
            txtMaHS.DataBindings.Add(new Binding("Text", GridHocSinh.DataSource, "mahs", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", GridHocSinh.DataSource, "hoten", true, DataSourceUpdateMode.Never));
            dateNS.DataBindings.Add(new Binding("Text", GridHocSinh.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", GridHocSinh.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            txtDienThoai.DataBindings.Add(new Binding("Text", GridHocSinh.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            cbLop.DataBindings.Add(new Binding("SelectedValue", GridHocSinh.DataSource, "malop", true, DataSourceUpdateMode.Never));
            txtHTC.DataBindings.Add(new Binding("Text", GridHocSinh.DataSource, "hotencha", true, DataSourceUpdateMode.Never));
            txtHTM.DataBindings.Add(new Binding("Text", GridHocSinh.DataSource, "hotenme", true, DataSourceUpdateMode.Never));
        }
        private void clear()
        {
            txtMaHS.Text = txtHoTen.Text = txtDiaChi.Text = txtDienThoai.Text = txtHTC.Text = txtHTM.Text = "";
        }
        private void ClearBinding()
        {
            txtMaHS.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            dateNS.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtHTC.DataBindings.Clear();
            txtHTM.DataBindings.Clear();
            cbLop.DataBindings.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà cung cấp " + txtHoTen.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var ans = new HOCSINHF().Delete(new HOCSINH { mahs = int.Parse(txtMaHS.Text) });
                    Init_(); ClearBinding(); Bindingtxt();
                }
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HOCSINH model = new HOCSINH()
                {
                    hoten = txtHoTen.Text,

                    ngaysinh = Convert.ToDateTime(dateNS.Text),
                    diachi = txtDiaChi.Text,
                    sdt = txtDienThoai.Text,


                };
                int ID_ = -1;
                if (txtMaHS.Text != "") ID_ = int.Parse(txtMaHS.Text.ToString());
                model.mahs = ID_;
                if (txtMaHS.Text == "")
                {
                    var result = new HOCSINHF().Insert(model);
                    if (result) MessageBox.Show("Done"); else MessageBox.Show("Lỗi");
                }
                else
                {
                    var result = new HOCSINHF().Update(model);
                    if (result) MessageBox.Show("Done"); else MessageBox.Show("Lỗi");
                }
                Init_(); ClearBinding(); Bindingtxt();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            GridHocSinh.DataSource = new HOCSINHF().Search(txtTimKiem.Text);
            ClearBinding(); Bindingtxt();
        }
    }
}