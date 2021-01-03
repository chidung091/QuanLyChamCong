namespace QuanLyChamCong
{
    partial class frm_MainDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainDev));
            this.menu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.btn_NguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NhomND = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChamCong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BaoCaoNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BaoCaoCC = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BaoCaoLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btn_GioiThieu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Dong = new DevExpress.XtraBars.BarButtonItem();
            this.frm_Main_DeV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ExpandCollapseItem.Id = 0;
            this.menu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.menu.ExpandCollapseItem,
            this.barListItem1,
            this.btn_NguoiDung,
            this.btn_NhomND,
            this.btn_NhanVien,
            this.btn_PhongBan,
            this.btn_ChamCong,
            this.barButtonItem1,
            this.btn_TinhLuong,
            this.btn_BaoCaoNV,
            this.btn_BaoCaoCC,
            this.btn_BaoCaoLuong,
            this.btn_GioiThieu,
            this.btn_Dong,
            this.menu.SearchEditItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.MaxItemId = 14;
            this.menu.Name = "menu";
            this.menu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.frm_Main_DeV,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage5,
            this.ribbonPage6,
            this.ribbonPage4});
            this.menu.Size = new System.Drawing.Size(802, 158);
            this.menu.StatusBar = this.ribbonStatusBar;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 1;
            this.barListItem1.Name = "barListItem1";
            // 
            // btn_NguoiDung
            // 
            this.btn_NguoiDung.Caption = "Người dùng";
            this.btn_NguoiDung.Id = 2;
            this.btn_NguoiDung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_NguoiDung.ImageOptions.LargeImage")));
            this.btn_NguoiDung.LargeWidth = 70;
            this.btn_NguoiDung.Name = "btn_NguoiDung";
            this.btn_NguoiDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NguoiDung_ItemClick);
            // 
            // btn_NhomND
            // 
            this.btn_NhomND.Caption = "Nhóm người dùng";
            this.btn_NhomND.Id = 3;
            this.btn_NhomND.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_NhomND.ImageOptions.LargeImage")));
            this.btn_NhomND.LargeWidth = 70;
            this.btn_NhomND.Name = "btn_NhomND";
            this.btn_NhomND.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhomND_ItemClick);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Caption = "Nhân viên";
            this.btn_NhanVien.Id = 4;
            this.btn_NhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.ImageOptions.LargeImage")));
            this.btn_NhanVien.LargeWidth = 70;
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhanVien_ItemClick);
            // 
            // btn_PhongBan
            // 
            this.btn_PhongBan.Caption = "Phòng ban";
            this.btn_PhongBan.Id = 5;
            this.btn_PhongBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_PhongBan.ImageOptions.LargeImage")));
            this.btn_PhongBan.LargeWidth = 70;
            this.btn_PhongBan.Name = "btn_PhongBan";
            this.btn_PhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PhongBan_ItemClick);
            // 
            // btn_ChamCong
            // 
            this.btn_ChamCong.Caption = "Chấm công";
            this.btn_ChamCong.Id = 6;
            this.btn_ChamCong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ChamCong.ImageOptions.LargeImage")));
            this.btn_ChamCong.LargeWidth = 70;
            this.btn_ChamCong.Name = "btn_ChamCong";
            this.btn_ChamCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ChamCong_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_TinhLuong
            // 
            this.btn_TinhLuong.Caption = "Tính lương";
            this.btn_TinhLuong.Id = 8;
            this.btn_TinhLuong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TinhLuong.ImageOptions.LargeImage")));
            this.btn_TinhLuong.LargeWidth = 70;
            this.btn_TinhLuong.Name = "btn_TinhLuong";
            this.btn_TinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TinhLuong_ItemClick);
            // 
            // btn_BaoCaoNV
            // 
            this.btn_BaoCaoNV.Caption = "Báo cáo nhân viên";
            this.btn_BaoCaoNV.Id = 9;
            this.btn_BaoCaoNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_BaoCaoNV.ImageOptions.LargeImage")));
            this.btn_BaoCaoNV.LargeWidth = 70;
            this.btn_BaoCaoNV.Name = "btn_BaoCaoNV";
            this.btn_BaoCaoNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BaoCaoNV_ItemClick);
            // 
            // btn_BaoCaoCC
            // 
            this.btn_BaoCaoCC.Caption = "Báo cáo chấm công";
            this.btn_BaoCaoCC.Id = 10;
            this.btn_BaoCaoCC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_BaoCaoCC.ImageOptions.LargeImage")));
            this.btn_BaoCaoCC.LargeWidth = 70;
            this.btn_BaoCaoCC.Name = "btn_BaoCaoCC";
            this.btn_BaoCaoCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BaoCaoCC_ItemClick);
            // 
            // btn_BaoCaoLuong
            // 
            this.btn_BaoCaoLuong.Caption = "Báo cáo lương";
            this.btn_BaoCaoLuong.Id = 11;
            this.btn_BaoCaoLuong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_BaoCaoLuong.ImageOptions.LargeImage")));
            this.btn_BaoCaoLuong.LargeWidth = 70;
            this.btn_BaoCaoLuong.Name = "btn_BaoCaoLuong";
            this.btn_BaoCaoLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BaoCaoLuong_ItemClick);
            // 
            // btn_GioiThieu
            // 
            this.btn_GioiThieu.Caption = "Giới thiệu";
            this.btn_GioiThieu.Id = 12;
            this.btn_GioiThieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_GioiThieu.ImageOptions.LargeImage")));
            this.btn_GioiThieu.LargeWidth = 70;
            this.btn_GioiThieu.Name = "btn_GioiThieu";
            this.btn_GioiThieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_GioiThieu_ItemClick);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Caption = "Đóng";
            this.btn_Dong.Id = 13;
            this.btn_Dong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Dong.ImageOptions.LargeImage")));
            this.btn_Dong.LargeWidth = 70;
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Dong_ItemClick);
            // 
            // frm_Main_DeV
            // 
            this.frm_Main_DeV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup10});
            this.frm_Main_DeV.Name = "frm_Main_DeV";
            this.frm_Main_DeV.Tag = "N2";
            this.frm_Main_DeV.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_NguoiDung);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Người dùng";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btn_NhomND);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "Nhóm người dùng";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Tag = "N2";
            this.ribbonPage2.Text = "Nhân sự";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_NhanVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Nhân viên";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_PhongBan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Phòng ban";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Chấm công - Tính lương";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_ChamCong);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Chấm công";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_TinhLuong);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tính lương";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Báo cáo - thống kê";
            this.ribbonPage5.Visible = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_BaoCaoNV);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Báo cáo nhân viên";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_BaoCaoCC);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Báo cáo chấm công";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btn_BaoCaoLuong);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Báo cáo lương";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Giới thiệu";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btn_GioiThieu);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Giới thiệu";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup11});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Đóng";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btn_Dong);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "Đóng";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 466);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.menu;
            this.ribbonStatusBar.Size = new System.Drawing.Size(802, 24);
            // 
            // frm_MainDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(802, 490);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.Name = "frm_MainDev";
            this.Ribbon = this.menu;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý chấm công";
            this.Load += new System.EventHandler(this.RibbonForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl menu;
        private DevExpress.XtraBars.Ribbon.RibbonPage frm_Main_DeV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarButtonItem btn_NguoiDung;
        private DevExpress.XtraBars.BarButtonItem btn_NhomND;
        private DevExpress.XtraBars.BarButtonItem btn_NhanVien;
        private DevExpress.XtraBars.BarButtonItem btn_PhongBan;
        private DevExpress.XtraBars.BarButtonItem btn_ChamCong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_TinhLuong;
        private DevExpress.XtraBars.BarButtonItem btn_BaoCaoNV;
        private DevExpress.XtraBars.BarButtonItem btn_BaoCaoCC;
        private DevExpress.XtraBars.BarButtonItem btn_BaoCaoLuong;
        private DevExpress.XtraBars.BarButtonItem btn_GioiThieu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btn_Dong;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
    }
}