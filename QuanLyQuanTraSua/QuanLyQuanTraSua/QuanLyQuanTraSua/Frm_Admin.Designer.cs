namespace QuanLyQuanTraSua
{
    partial class Frm_Admin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.tpDrink = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmPriceNuoc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmbDanhMucNuoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTenNuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtIDNuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXemNuoc = new System.Windows.Forms.Button();
            this.btnSuaNuoc = new System.Windows.Forms.Button();
            this.btnXoaNuoc = new System.Windows.Forms.Button();
            this.btnThemNuoc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvNuocUong = new System.Windows.Forms.DataGridView();
            this.tpTaiKhoan = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnDatLaiMatKhau = new System.Windows.Forms.Button();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.btnXemTaiKhoan = new System.Windows.Forms.Button();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.panel29 = new System.Windows.Forms.Panel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.nmLoaiTaiKhoan = new System.Windows.Forms.NumericUpDown();
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpDrink.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceNuoc)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuocUong)).BeginInit();
            this.tpTaiKhoan.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLoaiTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpDrink);
            this.tcAdmin.Controls.Add(this.tpTaiKhoan);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(776, 490);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(768, 464);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBill);
            this.panel2.Location = new System.Drawing.Point(6, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 411);
            this.panel2.TabIndex = 1;
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(3, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(750, 405);
            this.dgvBill.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.dtpkToDate);
            this.panel1.Controls.Add(this.dtpkFromDate);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(333, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(105, 29);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkToDate.Location = new System.Drawing.Point(553, 3);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFromDate.Location = new System.Drawing.Point(3, 3);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(189, 20);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // tpDrink
            // 
            this.tpDrink.Controls.Add(this.panel5);
            this.tpDrink.Controls.Add(this.panel4);
            this.tpDrink.Controls.Add(this.panel3);
            this.tpDrink.Location = new System.Drawing.Point(4, 22);
            this.tpDrink.Name = "tpDrink";
            this.tpDrink.Padding = new System.Windows.Forms.Padding(3);
            this.tpDrink.Size = new System.Drawing.Size(768, 464);
            this.tpDrink.TabIndex = 1;
            this.tpDrink.Text = "Nước uống";
            this.tpDrink.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(375, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(387, 377);
            this.panel5.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmPriceNuoc);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 162);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(381, 47);
            this.panel10.TabIndex = 6;
            // 
            // nmPriceNuoc
            // 
            this.nmPriceNuoc.Location = new System.Drawing.Point(124, 16);
            this.nmPriceNuoc.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmPriceNuoc.Name = "nmPriceNuoc";
            this.nmPriceNuoc.Size = new System.Drawing.Size(247, 20);
            this.nmPriceNuoc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cmbDanhMucNuoc);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 109);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(381, 47);
            this.panel9.TabIndex = 5;
            // 
            // cmbDanhMucNuoc
            // 
            this.cmbDanhMucNuoc.FormattingEnabled = true;
            this.cmbDanhMucNuoc.Location = new System.Drawing.Point(124, 15);
            this.cmbDanhMucNuoc.Name = "cmbDanhMucNuoc";
            this.cmbDanhMucNuoc.Size = new System.Drawing.Size(247, 21);
            this.cmbDanhMucNuoc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtTenNuoc);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(3, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(381, 47);
            this.panel8.TabIndex = 4;
            // 
            // txtTenNuoc
            // 
            this.txtTenNuoc.Location = new System.Drawing.Point(124, 15);
            this.txtTenNuoc.Name = "txtTenNuoc";
            this.txtTenNuoc.Size = new System.Drawing.Size(247, 20);
            this.txtTenNuoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nước:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtIDNuoc);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(381, 47);
            this.panel7.TabIndex = 3;
            // 
            // txtIDNuoc
            // 
            this.txtIDNuoc.Location = new System.Drawing.Point(124, 15);
            this.txtIDNuoc.Name = "txtIDNuoc";
            this.txtIDNuoc.ReadOnly = true;
            this.txtIDNuoc.Size = new System.Drawing.Size(247, 20);
            this.txtIDNuoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnXemNuoc);
            this.panel4.Controls.Add(this.btnSuaNuoc);
            this.panel4.Controls.Add(this.btnXoaNuoc);
            this.panel4.Controls.Add(this.btnThemNuoc);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 69);
            this.panel4.TabIndex = 1;
            // 
            // btnXemNuoc
            // 
            this.btnXemNuoc.Location = new System.Drawing.Point(277, 3);
            this.btnXemNuoc.Name = "btnXemNuoc";
            this.btnXemNuoc.Size = new System.Drawing.Size(83, 63);
            this.btnXemNuoc.TabIndex = 3;
            this.btnXemNuoc.Text = "Xem";
            this.btnXemNuoc.UseVisualStyleBackColor = true;
            this.btnXemNuoc.Click += new System.EventHandler(this.btnXemNuoc_Click);
            // 
            // btnSuaNuoc
            // 
            this.btnSuaNuoc.Location = new System.Drawing.Point(188, 3);
            this.btnSuaNuoc.Name = "btnSuaNuoc";
            this.btnSuaNuoc.Size = new System.Drawing.Size(83, 63);
            this.btnSuaNuoc.TabIndex = 2;
            this.btnSuaNuoc.Text = "Sửa";
            this.btnSuaNuoc.UseVisualStyleBackColor = true;
            this.btnSuaNuoc.Click += new System.EventHandler(this.btnSuaNuoc_Click);
            // 
            // btnXoaNuoc
            // 
            this.btnXoaNuoc.Location = new System.Drawing.Point(92, 3);
            this.btnXoaNuoc.Name = "btnXoaNuoc";
            this.btnXoaNuoc.Size = new System.Drawing.Size(83, 63);
            this.btnXoaNuoc.TabIndex = 1;
            this.btnXoaNuoc.Text = "Xóa";
            this.btnXoaNuoc.UseVisualStyleBackColor = true;
            this.btnXoaNuoc.Click += new System.EventHandler(this.btnXoaNuoc_Click);
            // 
            // btnThemNuoc
            // 
            this.btnThemNuoc.Location = new System.Drawing.Point(3, 3);
            this.btnThemNuoc.Name = "btnThemNuoc";
            this.btnThemNuoc.Size = new System.Drawing.Size(83, 63);
            this.btnThemNuoc.TabIndex = 0;
            this.btnThemNuoc.Text = "Thêm";
            this.btnThemNuoc.UseVisualStyleBackColor = true;
            this.btnThemNuoc.Click += new System.EventHandler(this.btnThemNuoc_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvNuocUong);
            this.panel3.Location = new System.Drawing.Point(6, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 377);
            this.panel3.TabIndex = 0;
            // 
            // dgvNuocUong
            // 
            this.dgvNuocUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuocUong.Location = new System.Drawing.Point(3, 3);
            this.dgvNuocUong.Name = "dgvNuocUong";
            this.dgvNuocUong.Size = new System.Drawing.Size(357, 371);
            this.dgvNuocUong.TabIndex = 0;
            // 
            // tpTaiKhoan
            // 
            this.tpTaiKhoan.Controls.Add(this.panel14);
            this.tpTaiKhoan.Controls.Add(this.panel28);
            this.tpTaiKhoan.Controls.Add(this.panel29);
            this.tpTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tpTaiKhoan.Name = "tpTaiKhoan";
            this.tpTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaiKhoan.Size = new System.Drawing.Size(768, 464);
            this.tpTaiKhoan.TabIndex = 4;
            this.tpTaiKhoan.Text = "Tài khoản";
            this.tpTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnDatLaiMatKhau);
            this.panel14.Controls.Add(this.panel25);
            this.panel14.Controls.Add(this.panel26);
            this.panel14.Controls.Add(this.panel27);
            this.panel14.Location = new System.Drawing.Point(375, 81);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(387, 377);
            this.panel14.TabIndex = 6;
            // 
            // btnDatLaiMatKhau
            // 
            this.btnDatLaiMatKhau.Location = new System.Drawing.Point(254, 162);
            this.btnDatLaiMatKhau.Name = "btnDatLaiMatKhau";
            this.btnDatLaiMatKhau.Size = new System.Drawing.Size(130, 53);
            this.btnDatLaiMatKhau.TabIndex = 6;
            this.btnDatLaiMatKhau.Text = "Đặt lại mật khẩu";
            this.btnDatLaiMatKhau.UseVisualStyleBackColor = true;
            this.btnDatLaiMatKhau.Click += new System.EventHandler(this.btnDatLaiMatKhau_Click);
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.nmLoaiTaiKhoan);
            this.panel25.Controls.Add(this.label11);
            this.panel25.Location = new System.Drawing.Point(3, 109);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(381, 47);
            this.panel25.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txtTenHienThi);
            this.panel26.Controls.Add(this.label12);
            this.panel26.Location = new System.Drawing.Point(3, 56);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(381, 47);
            this.panel26.TabIndex = 4;
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Location = new System.Drawing.Point(137, 15);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(234, 20);
            this.txtTenHienThi.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên hiển thị:";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txtTenTaiKhoan);
            this.panel27.Controls.Add(this.label13);
            this.panel27.Location = new System.Drawing.Point(3, 3);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(381, 47);
            this.panel27.TabIndex = 3;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(137, 15);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(234, 20);
            this.txtTenTaiKhoan.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên tài khoản:";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.btnXemTaiKhoan);
            this.panel28.Controls.Add(this.btnSuaTaiKhoan);
            this.panel28.Controls.Add(this.btnXoaTaiKhoan);
            this.panel28.Controls.Add(this.btnThemTaiKhoan);
            this.panel28.Location = new System.Drawing.Point(6, 6);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(363, 69);
            this.panel28.TabIndex = 5;
            // 
            // btnXemTaiKhoan
            // 
            this.btnXemTaiKhoan.Location = new System.Drawing.Point(277, 3);
            this.btnXemTaiKhoan.Name = "btnXemTaiKhoan";
            this.btnXemTaiKhoan.Size = new System.Drawing.Size(83, 63);
            this.btnXemTaiKhoan.TabIndex = 3;
            this.btnXemTaiKhoan.Text = "Xem";
            this.btnXemTaiKhoan.UseVisualStyleBackColor = true;
            this.btnXemTaiKhoan.Click += new System.EventHandler(this.btnXemTaiKhoan_Click);
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(188, 3);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(83, 63);
            this.btnSuaTaiKhoan.TabIndex = 2;
            this.btnSuaTaiKhoan.Text = "Sửa";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnSuaTaiKhoan.Click += new System.EventHandler(this.btnSuaTaiKhoan_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(92, 3);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(83, 63);
            this.btnXoaTaiKhoan.TabIndex = 1;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(83, 63);
            this.btnThemTaiKhoan.TabIndex = 0;
            this.btnThemTaiKhoan.Text = "Thêm";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.dgvTaiKhoan);
            this.panel29.Location = new System.Drawing.Point(6, 81);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(363, 377);
            this.panel29.TabIndex = 4;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(357, 371);
            this.dgvTaiKhoan.TabIndex = 0;
            // 
            // nmLoaiTaiKhoan
            // 
            this.nmLoaiTaiKhoan.Location = new System.Drawing.Point(137, 16);
            this.nmLoaiTaiKhoan.Name = "nmLoaiTaiKhoan";
            this.nmLoaiTaiKhoan.Size = new System.Drawing.Size(57, 20);
            this.nmLoaiTaiKhoan.TabIndex = 1;
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.tcAdmin);
            this.Name = "Frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Admin";
            this.tcAdmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tpDrink.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceNuoc)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuocUong)).EndInit();
            this.tpTaiKhoan.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLoaiTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpDrink;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.TabPage tpTaiKhoan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXemNuoc;
        private System.Windows.Forms.Button btnSuaNuoc;
        private System.Windows.Forms.Button btnXoaNuoc;
        private System.Windows.Forms.Button btnThemNuoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvNuocUong;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmPriceNuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cmbDanhMucNuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTenNuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnDatLaiMatKhau;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Button btnXemTaiKhoan;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtIDNuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmLoaiTaiKhoan;
    }
}