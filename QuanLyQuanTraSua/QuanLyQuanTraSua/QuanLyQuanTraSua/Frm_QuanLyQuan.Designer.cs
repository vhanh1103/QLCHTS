namespace QuanLyQuanTraSua
{
    partial class Frm_QuanLyQuan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongTinCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmGioiHanThem = new System.Windows.Forms.NumericUpDown();
            this.btnThemNuoc = new System.Windows.Forms.Button();
            this.flTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGioiHanThem)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAdmin,
            this.mnThongTinTaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnAdmin
            // 
            this.mnAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnAdmin.Name = "mnAdmin";
            this.mnAdmin.Size = new System.Drawing.Size(61, 23);
            this.mnAdmin.Text = "Admin";
            this.mnAdmin.Click += new System.EventHandler(this.mnAdmin_Click);
            // 
            // mnThongTinTaiKhoan
            // 
            this.mnThongTinTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongTinCaNhan,
            this.mnDangXuat});
            this.mnThongTinTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnThongTinTaiKhoan.Name = "mnThongTinTaiKhoan";
            this.mnThongTinTaiKhoan.Size = new System.Drawing.Size(141, 23);
            this.mnThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // mnThongTinCaNhan
            // 
            this.mnThongTinCaNhan.Name = "mnThongTinCaNhan";
            this.mnThongTinCaNhan.Size = new System.Drawing.Size(189, 24);
            this.mnThongTinCaNhan.Text = "Thông tin cá nhân";
            this.mnThongTinCaNhan.Click += new System.EventHandler(this.mnThongTinCaNhan_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(189, 24);
            this.mnDangXuat.Text = "Đăng xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvHoaDon);
            this.panel2.Location = new System.Drawing.Point(384, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 317);
            this.panel2.TabIndex = 2;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(3, 3);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(398, 311);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 152;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 162;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtThanhToan);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(384, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 62);
            this.panel3.TabIndex = 3;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhToan.ForeColor = System.Drawing.Color.Red;
            this.txtThanhToan.Location = new System.Drawing.Point(148, 16);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.ReadOnly = true;
            this.txtThanhToan.Size = new System.Drawing.Size(156, 23);
            this.txtThanhToan.TabIndex = 10;
            this.txtThanhToan.Text = "0";
            this.txtThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(323, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 54);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(3, 3);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(230, 21);
            this.cmbCategory.TabIndex = 4;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbFood
            // 
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(3, 36);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(230, 21);
            this.cmbFood.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmGioiHanThem);
            this.panel4.Controls.Add(this.btnThemNuoc);
            this.panel4.Controls.Add(this.cmbFood);
            this.panel4.Controls.Add(this.cmbCategory);
            this.panel4.Location = new System.Drawing.Point(387, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 60);
            this.panel4.TabIndex = 4;
            // 
            // nmGioiHanThem
            // 
            this.nmGioiHanThem.Location = new System.Drawing.Point(320, 22);
            this.nmGioiHanThem.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmGioiHanThem.Name = "nmGioiHanThem";
            this.nmGioiHanThem.Size = new System.Drawing.Size(75, 20);
            this.nmGioiHanThem.TabIndex = 7;
            this.nmGioiHanThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmGioiHanThem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemNuoc
            // 
            this.btnThemNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNuoc.Location = new System.Drawing.Point(239, 3);
            this.btnThemNuoc.Name = "btnThemNuoc";
            this.btnThemNuoc.Size = new System.Drawing.Size(75, 54);
            this.btnThemNuoc.TabIndex = 6;
            this.btnThemNuoc.Text = "Thêm nước";
            this.btnThemNuoc.UseVisualStyleBackColor = true;
            this.btnThemNuoc.Click += new System.EventHandler(this.btnThemNuoc_Click);
            // 
            // flTable
            // 
            this.flTable.Location = new System.Drawing.Point(12, 27);
            this.flTable.Name = "flTable";
            this.flTable.Size = new System.Drawing.Size(366, 451);
            this.flTable.TabIndex = 5;
            // 
            // Frm_QuanLyQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.flTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_QuanLyQuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmGioiHanThem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnThongTinCaNhan;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmGioiHanThem;
        private System.Windows.Forms.Button btnThemNuoc;
        private System.Windows.Forms.FlowLayoutPanel flTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtThanhToan;
    }
}