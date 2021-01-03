namespace QuanLyChamCong
{
    partial class frm_QLPhongBan
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThemMoiPB = new System.Windows.Forms.ToolStripButton();
            this.tsbLuuPB = new System.Windows.Forms.ToolStripButton();
            this.tsbXoaPB = new System.Windows.Forms.ToolStripButton();
            this.tsbSuaPB = new System.Windows.Forms.ToolStripButton();
            this.tsbThoatPB = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.MaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThemMoiPB,
            this.tsbLuuPB,
            this.tsbXoaPB,
            this.tsbSuaPB,
            this.tsbThoatPB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(438, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbThemMoiPB
            // 
            this.tsbThemMoiPB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbThemMoiPB.Image = global::QuanLyChamCong.Properties.Resources.tsbAddNew;
            this.tsbThemMoiPB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThemMoiPB.Name = "tsbThemMoiPB";
            this.tsbThemMoiPB.Size = new System.Drawing.Size(84, 22);
            this.tsbThemMoiPB.Text = "Thêm mới";
            this.tsbThemMoiPB.Click += new System.EventHandler(this.tsbThemMoiPB_Click);
            // 
            // tsbLuuPB
            // 
            this.tsbLuuPB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLuuPB.Image = global::QuanLyChamCong.Properties.Resources.tsbSave;
            this.tsbLuuPB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuuPB.Name = "tsbLuuPB";
            this.tsbLuuPB.Size = new System.Drawing.Size(48, 22);
            this.tsbLuuPB.Text = "Lưu";
            this.tsbLuuPB.Click += new System.EventHandler(this.tsbLuuPB_Click);
            // 
            // tsbXoaPB
            // 
            this.tsbXoaPB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbXoaPB.Image = global::QuanLyChamCong.Properties.Resources.tsbDelete;
            this.tsbXoaPB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoaPB.Name = "tsbXoaPB";
            this.tsbXoaPB.Size = new System.Drawing.Size(48, 22);
            this.tsbXoaPB.Text = "Xóa";
            this.tsbXoaPB.Click += new System.EventHandler(this.tsbXoaPB_Click);
            // 
            // tsbSuaPB
            // 
            this.tsbSuaPB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSuaPB.Image = global::QuanLyChamCong.Properties.Resources.tsbProcess;
            this.tsbSuaPB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSuaPB.Name = "tsbSuaPB";
            this.tsbSuaPB.Size = new System.Drawing.Size(48, 22);
            this.tsbSuaPB.Text = "Sửa";
            this.tsbSuaPB.Click += new System.EventHandler(this.tsbSuaPB_Click_1);
            // 
            // tsbThoatPB
            // 
            this.tsbThoatPB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbThoatPB.Image = global::QuanLyChamCong.Properties.Resources.tsbClose;
            this.tsbThoatPB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThoatPB.Name = "tsbThoatPB";
            this.tsbThoatPB.Size = new System.Drawing.Size(59, 22);
            this.tsbThoatPB.Text = "Thoát";
            this.tsbThoatPB.Click += new System.EventHandler(this.tsbThoatPB_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPhongBan, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMaPB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenPB, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 359);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AllowUserToDeleteRows = false;
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhongBan,
            this.TenPhongBan});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvPhongBan, 4);
            this.dgvPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongBan.Location = new System.Drawing.Point(3, 72);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(432, 284);
            this.dgvPhongBan.TabIndex = 20;
            this.dgvPhongBan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPhongBan_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã Phòng Ban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên Phòng Ban:";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPB.Location = new System.Drawing.Point(218, 13);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(121, 21);
            this.txtMaPB.TabIndex = 23;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPB.Location = new System.Drawing.Point(218, 43);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(121, 21);
            this.txtTenPB.TabIndex = 24;
            // 
            // MaPhongBan
            // 
            this.MaPhongBan.DataPropertyName = "MaPhongBan";
            this.MaPhongBan.HeaderText = "Mã Phòng Ban";
            this.MaPhongBan.Name = "MaPhongBan";
            this.MaPhongBan.ReadOnly = true;
            // 
            // TenPhongBan
            // 
            this.TenPhongBan.DataPropertyName = "TenPhongBan";
            this.TenPhongBan.HeaderText = "Tên Phòng Ban";
            this.TenPhongBan.Name = "TenPhongBan";
            this.TenPhongBan.ReadOnly = true;
            // 
            // frm_QLPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_QLPhongBan";
            this.Text = "Quản lý phòng ban";
            this.Load += new System.EventHandler(this.frm_QLPhongBan_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbThemMoiPB;
        private System.Windows.Forms.ToolStripButton tsbLuuPB;
        private System.Windows.Forms.ToolStripButton tsbXoaPB;
        private System.Windows.Forms.ToolStripButton tsbSuaPB;
        private System.Windows.Forms.ToolStripButton tsbThoatPB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongBan;
    }
}