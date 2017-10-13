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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        public frmLop()
        {
            InitializeComponent();
            for (int i = 1980; i <= 2030; i++) { txtNamHoc.Items.Add(string.Format(i + "-" + (i + 1).ToString())); }
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
            source.DataSource = new LOPF().LOPs.ToList();
            GridLop.DataSource = source;
        }
        private void Bindingtxt()
        {
            txtMaLop.DataBindings.Add(new Binding("Text", GridLop.DataSource, "malop", true, DataSourceUpdateMode.Never));
            txtTenLop.DataBindings.Add(new Binding("Text", GridLop.DataSource, "tenlop", true, DataSourceUpdateMode.Never));
            txtQuanSo.DataBindings.Add(new Binding("Text", GridLop.DataSource, "quanso", true, DataSourceUpdateMode.Never));
            txtNamHoc.DataBindings.Add(new Binding("Text", GridLop.DataSource, "namhoc", true, DataSourceUpdateMode.Never));
        }
        private void clear()
        {
            txtMaLop.Text = txtTenLop.Text = txtQuanSo.Text = txtNamHoc.Text = "";
        }
        private void ClearBinding()
        {
            txtMaLop.DataBindings.Clear();
            txtTenLop.DataBindings.Clear();
            txtQuanSo.DataBindings.Clear();
            txtNamHoc.DataBindings.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà cung cấp " + txtTenLop.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var ans = new LOPF().Delete(new LOP { malop = int.Parse(txtMaLop.Text) });
                    Init_(); ClearBinding(); Bindingtxt();
                }
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                LOP model = new LOP()
                {
                    tenlop = txtTenLop.Text,
                    quanso = int.Parse(txtQuanSo.Text),
                    namhoc=txtNamHoc.Text
                };
                int ID_ = -1;
                if (txtMaLop.Text != "") ID_ = int.Parse(txtMaLop.Text.ToString());
                model.malop = ID_;
                if (txtMaLop.Text == "")
                {
                    var result = new LOPF().Insert(model);
                    if (result) MessageBox.Show("Done"); else MessageBox.Show("Lỗi");
                }
                else
                {
                    var result = new LOPF().Update(model);
                    if (result) MessageBox.Show("Done"); else MessageBox.Show("Lỗi");
                }
                Init_(); ClearBinding(); Bindingtxt();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            GridLop.DataSource = new LOPF().Search(txtTimKiem.Text);
            ClearBinding(); Bindingtxt();
        }
    }
}