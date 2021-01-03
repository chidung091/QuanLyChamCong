namespace QuanLyChamCong
{
    partial class frm_QLChamCong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripThemMoi = new System.Windows.Forms.ToolStripButton();
            this.toolStripXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripThoat = new System.Windows.Forms.ToolStripButton();
            this.cbo_Ngay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_PhongBan = new System.Windows.Forms.ComboBox();
            this.cbo_Nam = new System.Windows.Forms.ComboBox();
            this.cbo_Thang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGioTC = new System.Windows.Forms.TextBox();
            this.chkNgayCong = new System.Windows.Forms.CheckBox();
            this.txtGioTre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_ChamCong = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChitiet = new System.Windows.Forms.DataGridView();
            this.NgayCong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioTangCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripThemMoi,
            this.toolStripXoa,
            this.toolStripSua,
            this.toolStripLuu,
            this.toolStripThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1017, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripThemMoi
            // 
            this.toolStripThemMoi.Image = global::QuanLyChamCong.Properties.Resources.tsbAddNew;
            this.toolStripThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripThemMoi.Name = "toolStripThemMoi";
            this.toolStripThemMoi.Size = new System.Drawing.Size(81, 22);
            this.toolStripThemMoi.Text = "Thêm mới";
            this.toolStripThemMoi.Click += new System.EventHandler(this.toolStripThemMoi_Click);
            // 
            // toolStripXoa
            // 
            this.toolStripXoa.Image = global::QuanLyChamCong.Properties.Resources.tsbDelete;
            this.toolStripXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripXoa.Name = "toolStripXoa";
            this.toolStripXoa.Size = new System.Drawing.Size(47, 22);
            this.toolStripXoa.Text = "Xóa";
            this.toolStripXoa.Click += new System.EventHandler(this.toolStripXoa_Click);
            // 
            // toolStripSua
            // 
            this.toolStripSua.Image = global::QuanLyChamCong.Properties.Resources.tsbProcess;
            this.toolStripSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSua.Name = "toolStripSua";
            this.toolStripSua.Size = new System.Drawing.Size(46, 22);
            this.toolStripSua.Text = "Sửa";
            this.toolStripSua.Click += new System.EventHandler(this.toolStripSua_Click);
            // 
            // toolStripLuu
            // 
            this.toolStripLuu.Image = global::QuanLyChamCong.Properties.Resources.tsbSave;
            this.toolStripLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLuu.Name = "toolStripLuu";
            this.toolStripLuu.Size = new System.Drawing.Size(47, 22);
            this.toolStripLuu.Text = "Lưu";
            this.toolStripLuu.Click += new System.EventHandler(this.toolStripLuu_Click_1);
            // 
            // toolStripThoat
            // 
            this.toolStripThoat.Image = global::QuanLyChamCong.Properties.Resources.tsbClose;
            this.toolStripThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripThoat.Name = "toolStripThoat";
            this.toolStripThoat.Size = new System.Drawing.Size(57, 22);
            this.toolStripThoat.Text = "Thoát";
            this.toolStripThoat.Click += new System.EventHandler(this.toolStripThoat_Click);
            // 
            // cbo_Ngay
            // 
            this.cbo_Ngay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Ngay.FormattingEnabled = true;
            this.cbo_Ngay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbo_Ngay.Location = new System.Drawing.Point(258, 63);
            this.cbo_Ngay.Name = "cbo_Ngay";
            this.cbo_Ngay.Size = new System.Drawing.Size(197, 21);
            this.cbo_Ngay.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên nhân viên:";
            // 
            // cbo_PhongBan
            // 
            this.cbo_PhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_PhongBan.FormattingEnabled = true;
            this.cbo_PhongBan.Location = new System.Drawing.Point(256, 91);
            this.cbo_PhongBan.Margin = new System.Windows.Forms.Padding(1);
            this.cbo_PhongBan.Name = "cbo_PhongBan";
            this.cbo_PhongBan.Size = new System.Drawing.Size(201, 21);
            this.cbo_PhongBan.TabIndex = 8;
            this.cbo_PhongBan.SelectedIndexChanged += new System.EventHandler(this.cbo_PhongBan_SelectedIndexChanged);
            // 
            // cbo_Nam
            // 
            this.cbo_Nam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Nam.FormattingEnabled = true;
            this.cbo_Nam.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbo_Nam.Location = new System.Drawing.Point(256, 31);
            this.cbo_Nam.Margin = new System.Windows.Forms.Padding(1);
            this.cbo_Nam.Name = "cbo_Nam";
            this.cbo_Nam.Size = new System.Drawing.Size(201, 21);
            this.cbo_Nam.TabIndex = 10;
            this.cbo_Nam.SelectedIndexChanged += new System.EventHandler(this.cbo_Nam_SelectedIndexChanged);
            // 
            // cbo_Thang
            // 
            this.cbo_Thang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Thang.FormattingEnabled = true;
            this.cbo_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbo_Thang.Location = new System.Drawing.Point(256, 1);
            this.cbo_Thang.Margin = new System.Windows.Forms.Padding(1);
            this.cbo_Thang.Name = "cbo_Thang";
            this.cbo_Thang.Size = new System.Drawing.Size(201, 21);
            this.cbo_Thang.TabIndex = 9;
            this.cbo_Thang.SelectedIndexChanged += new System.EventHandler(this.cbo_Thang_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Giơ tăng ca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phòng ban:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 30);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ngày:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(561, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Giờ trễ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm:";
            // 
            // txtGioTC
            // 
            this.txtGioTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioTC.Location = new System.Drawing.Point(679, 31);
            this.txtGioTC.Margin = new System.Windows.Forms.Padding(1);
            this.txtGioTC.Name = "txtGioTC";
            this.txtGioTC.Size = new System.Drawing.Size(201, 20);
            this.txtGioTC.TabIndex = 22;
            this.txtGioTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGioTC_KeyPress);
            // 
            // chkNgayCong
            // 
            this.chkNgayCong.AutoSize = true;
            this.chkNgayCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkNgayCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNgayCong.Location = new System.Drawing.Point(681, 93);
            this.chkNgayCong.Name = "chkNgayCong";
            this.chkNgayCong.Size = new System.Drawing.Size(197, 24);
            this.chkNgayCong.TabIndex = 26;
            this.chkNgayCong.Text = "Có đi làm";
            this.chkNgayCong.UseVisualStyleBackColor = true;
            // 
            // txtGioTre
            // 
            this.txtGioTre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioTre.Location = new System.Drawing.Point(679, 61);
            this.txtGioTre.Margin = new System.Windows.Forms.Padding(1);
            this.txtGioTre.Name = "txtGioTre";
            this.txtGioTre.Size = new System.Drawing.Size(201, 20);
            this.txtGioTre.TabIndex = 24;
            this.txtGioTre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGioTre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGioTre, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkNgayCong, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtGioTC, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbo_Thang, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbo_Nam, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbo_PhongBan, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbo_Ngay, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ChamCong, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgvChitiet, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxNhanVien, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 389);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // dgv_ChamCong
            // 
            this.dgv_ChamCong.AllowUserToAddRows = false;
            this.dgv_ChamCong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_ChamCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_ChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChamCong.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_ChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Column1,
            this.Thang,
            this.Nam,
            this.NgayLam,
            this.Column3,
            this.Column4});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_ChamCong, 5);
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ChamCong.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_ChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChamCong.Location = new System.Drawing.Point(3, 123);
            this.dgv_ChamCong.Name = "dgv_ChamCong";
            this.dgv_ChamCong.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChamCong.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_ChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ChamCong.Size = new System.Drawing.Size(672, 243);
            this.dgv_ChamCong.TabIndex = 31;
            this.dgv_ChamCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_ChamCong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNhanVien";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HoTen";
            this.Column1.HeaderText = "Tên NV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.FillWeight = 50F;
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.FillWeight = 50F;
            this.Nam.HeaderText = "Năm";
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            // 
            // NgayLam
            // 
            this.NgayLam.DataPropertyName = "SoNgayChamCong";
            this.NgayLam.FillWeight = 50F;
            this.NgayLam.HeaderText = "Số Ngày Làm";
            this.NgayLam.Name = "NgayLam";
            this.NgayLam.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoGioTangCa";
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Số Giờ Tăng Ca";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoGioTre";
            this.Column4.HeaderText = "Số Giờ Trễ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dgvChitiet
            // 
            this.dgvChitiet.AllowUserToAddRows = false;
            this.dgvChitiet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvChitiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvChitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChitiet.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChitiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayCong,
            this.Ngay,
            this.GioTangCa,
            this.GioTre});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvChitiet, 2);
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChitiet.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvChitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChitiet.Location = new System.Drawing.Point(681, 123);
            this.dgvChitiet.Name = "dgvChitiet";
            this.dgvChitiet.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChitiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvChitiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChitiet.Size = new System.Drawing.Size(333, 243);
            this.dgvChitiet.TabIndex = 32;
            this.dgvChitiet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvChitiet_MouseClick);
            // 
            // NgayCong
            // 
            this.NgayCong.DataPropertyName = "NgayCong";
            this.NgayCong.FillWeight = 50F;
            this.NgayCong.HeaderText = "Công";
            this.NgayCong.Name = "NgayCong";
            this.NgayCong.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 50;
            // 
            // GioTangCa
            // 
            this.GioTangCa.DataPropertyName = "SoGioTangCa";
            this.GioTangCa.HeaderText = "Giờ tăng ca";
            this.GioTangCa.Name = "GioTangCa";
            this.GioTangCa.ReadOnly = true;
            // 
            // GioTre
            // 
            this.GioTre.DataPropertyName = "SoGioTre";
            this.GioTre.HeaderText = "Giờ trễ";
            this.GioTre.Name = "GioTre";
            this.GioTre.ReadOnly = true;
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(681, 3);
            this.cbxNhanVien.MaxDropDownItems = 5;
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(197, 21);
            this.cbxNhanVien.TabIndex = 33;
            this.cbxNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbxNhanVien_SelectedIndexChanged);
            // 
            // frm_QLChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 414);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_QLChamCong";
            this.Text = "Quản lý chấm công";
            this.Load += new System.EventHandler(this.frm_QLChamCong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripLuu;
        private System.Windows.Forms.ToolStripButton toolStripXoa;
        private System.Windows.Forms.ToolStripButton toolStripSua;
        private System.Windows.Forms.ToolStripButton toolStripThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripThemMoi;
        private System.Windows.Forms.ComboBox cbo_Ngay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGioTre;
        private System.Windows.Forms.CheckBox chkNgayCong;
        private System.Windows.Forms.TextBox txtGioTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_Thang;
        private System.Windows.Forms.ComboBox cbo_Nam;
        private System.Windows.Forms.ComboBox cbo_PhongBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_ChamCong;
        private System.Windows.Forms.DataGridView dgvChitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioTangCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioTre;
        private System.Windows.Forms.ComboBox cbxNhanVien;
    }
}