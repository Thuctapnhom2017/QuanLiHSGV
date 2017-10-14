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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmMonHoc()
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
            source.DataSource = new MONHOCF().MONHOCs.ToList();
            GridMon.DataSource = source;
        }
        private void Bindingtxt()
        {
            txtID.DataBindings.Add(new Binding("Text", GridMon.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", GridMon.DataSource, "tenmon", true, DataSourceUpdateMode.Never));
            txtNote.DataBindings.Add(new Binding("Text", GridMon.DataSource, "note", true, DataSourceUpdateMode.Never));
        }
        private void clear()
        {
            txtID.Text = txtName.Text = txtNote.Text = "";
        }
        private void ClearBinding()
        {
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtNote.DataBindings.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà cung cấp " + txtName.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var ans = new MONHOCF().Delete(new MONHOC { ID = int.Parse(txtID.Text) });
                    Init_(); ClearBinding(); Bindingtxt();
                }
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                MONHOC model = new MONHOC()
                {
                    tenmon = txtName.Text,
                    note = txtNote.Text,
                };
                int ID_ = -1;
                if (txtID.Text != "") ID_ = int.Parse(txtID.Text.ToString());
                model.ID = ID_;
                if (txtID.Text == "")
                {
                    var result = new MONHOCF().Insert(model);
                    if (result) MessageBox.Show("Done"); else MessageBox.Show("Lỗi");
                }
                else
                {
                    var result = new MONHOCF().Update(model);
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
            GridMon.DataSource = new MONHOCF().Search(txtTimKiem.Text);
            ClearBinding(); Bindingtxt();
        }
    }
}