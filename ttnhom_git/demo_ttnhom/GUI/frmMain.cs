using demo_ttnhom.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demo_ttnhom
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            PhanQuyen();
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void PhanQuyen()
        {
            if (Constant.NGUOIDUNG_ != null)
            {
                btnDangNhap.Enabled = false;
                if (Constant.NGUOIDUNG_.Admin == true)
                {

                }
                else
                {

                }
            }
            else
            {
                btnDangNhap.Enabled = true;
                btnDangXuat.Enabled = btnTTND.Enabled = btnHS.Enabled = btnGV.Enabled = btnMonHoc.Enabled = btnLop.Enabled = btnPCGD.Enabled = false;
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng Xuất", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) { Constant.NGUOIDUNG_ = null; PhanQuyen(); }
        }

        private void btnTTND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinNguoiDung frm = new frmThongTinNguoiDung();
            frm.ShowDialog();
        }

        private void btnHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHocSinh frm = new frmHocSinh();
            frm.ShowDialog();
        }

        private void btnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGiaoVien frm = new frmGiaoVien();
            frm.ShowDialog();
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLop frm = new frmLop();
            frm.ShowDialog();
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            frm.ShowDialog();
        }

        private void btnPCGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPCGD frm = new frmPCGD();
            frm.ShowDialog();
        }
    }
}
