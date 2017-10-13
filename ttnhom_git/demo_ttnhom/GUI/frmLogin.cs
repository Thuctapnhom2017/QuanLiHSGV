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

namespace demo_ttnhom.GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int result = new NGUOIDUNGF().Login(txtUserName.Text, txtPassword.Text);
            if (result > -1)
            {
                MessageBox.Show("Done");
                Constant.NGUOIDUNG_ = new NGUOIDUNGF().FindEntity(txtUserName.Text);
                this.Hide();
                frmMain frm = new frmMain();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}