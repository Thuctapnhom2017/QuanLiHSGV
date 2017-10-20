namespace demo_ttnhom
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTTND = new DevExpress.XtraBars.BarButtonItem();
            this.btnHS = new DevExpress.XtraBars.BarButtonItem();
            this.btnGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPCGD = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTroGiup = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnTTND,
            this.btnHS,
            this.btnGV,
            this.btnPCGD,
            this.barButtonItem4,
            this.btnLop,
            this.btnMonHoc,
            this.btnTroGiup});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(915, 143);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.LargeGlyph")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Glyph")));
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnTTND
            // 
            this.btnTTND.Caption = "Thông Tin Tài Khoản";
            this.btnTTND.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTTND.Glyph")));
            this.btnTTND.Id = 3;
            this.btnTTND.Name = "btnTTND";
            this.btnTTND.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTTND_ItemClick);
            // 
            // btnHS
            // 
            this.btnHS.Caption = "Học Sinh";
            this.btnHS.Id = 4;
            this.btnHS.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHS.LargeGlyph")));
            this.btnHS.Name = "btnHS";
            this.btnHS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHS_ItemClick);
            // 
            // btnGV
            // 
            this.btnGV.Caption = "Giáo Viên";
            this.btnGV.Id = 5;
            this.btnGV.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGV.LargeGlyph")));
            this.btnGV.Name = "btnGV";
            this.btnGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGV_ItemClick);
            // 
            // btnPCGD
            // 
            this.btnPCGD.Caption = "Phân Công Giảng Dạy";
            this.btnPCGD.Id = 6;
            this.btnPCGD.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPCGD.LargeGlyph")));
            this.btnPCGD.Name = "btnPCGD";
            this.btnPCGD.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPCGD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPCGD_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Quản lý điểm";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp Học";
            this.btnLop.Id = 8;
            this.btnLop.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLop.LargeGlyph")));
            this.btnLop.Name = "btnLop";
            this.btnLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn Học";
            this.btnMonHoc.Id = 9;
            this.btnMonHoc.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.LargeGlyph")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Caption = "Trợ Giúp";
            this.btnTroGiup.Id = 10;
            this.btnTroGiup.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTroGiup.LargeGlyph")));
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTroGiup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTroGiup_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang Chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTTND);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài Khoản";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh Mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHS);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGV);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Học Sinh";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPCGD);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Phân Công";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Trợ Giúp";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTroGiup);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Trợ Giúp";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 492);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnTTND;
        private DevExpress.XtraBars.BarButtonItem btnHS;
        private DevExpress.XtraBars.BarButtonItem btnGV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnPCGD;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnTroGiup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}

