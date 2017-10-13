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
using demo_ttnhom.EF;
using demo_ttnhom.Function;

namespace demo_ttnhom.GUI
{
    public partial class frmThongTinNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinNguoiDung()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            NGUOIDUNG model = new NGUOIDUNG { UserName = txtUserName.Text, PassWord = txtPassword.Text,};
            var ans = new NGUOIDUNGF().Update(model);
            if (ans)
            {
                Constant.NGUOIDUNG_ = model;
                MessageBox.Show("Done");
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}