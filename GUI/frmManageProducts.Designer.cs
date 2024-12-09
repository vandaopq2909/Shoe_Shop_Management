namespace GUI
{
    partial class frmManageProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckbTrangThai = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTenLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnChonAnhSP = new Guna.UI2.WinForms.Guna2Button();
            this.ptbSanPham = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMauSac = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKichThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThuongHieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 57);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách Sản phẩm";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "Tìm kiếm tên sản phẩm...";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::GUI.Properties.Resources.search;
            this.txtSearch.Location = new System.Drawing.Point(847, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(376, 47);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ckbTrangThai);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.nudSoLuong);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxTenLoai);
            this.panel2.Controls.Add(this.btnChonAnhSP);
            this.panel2.Controls.Add(this.ptbSanPham);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtMoTa);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMauSac);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtKichThuoc);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtGiaBan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtThuongHieu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTenSP);
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaSP);
            this.panel2.Controls.Add(this.dgvProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 682);
            this.panel2.TabIndex = 3;
            // 
            // ckbTrangThai
            // 
            this.ckbTrangThai.AutoSize = true;
            this.ckbTrangThai.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.ckbTrangThai.CheckedState.BorderRadius = 0;
            this.ckbTrangThai.CheckedState.BorderThickness = 0;
            this.ckbTrangThai.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.ckbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.ckbTrangThai.Location = new System.Drawing.Point(426, 485);
            this.ckbTrangThai.Name = "ckbTrangThai";
            this.ckbTrangThai.Size = new System.Drawing.Size(115, 26);
            this.ckbTrangThai.TabIndex = 56;
            this.ckbTrangThai.Text = "Còn hàng";
            this.ckbTrangThai.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbTrangThai.UncheckedState.BorderRadius = 0;
            this.ckbTrangThai.UncheckedState.BorderThickness = 0;
            this.ckbTrangThai.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(272, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(422, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 24);
            this.label11.TabIndex = 54;
            this.label11.Text = "Trạng thái";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.nudSoLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.nudSoLuong.BorderRadius = 5;
            this.nudSoLuong.BorderThickness = 2;
            this.nudSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudSoLuong.Location = new System.Drawing.Point(272, 478);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(104, 38);
            this.nudSoLuong.TabIndex = 52;
            this.nudSoLuong.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.nudSoLuong.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(32, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên Loại";
            // 
            // cbxTenLoai
            // 
            this.cbxTenLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbxTenLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.cbxTenLoai.BorderRadius = 10;
            this.cbxTenLoai.BorderThickness = 2;
            this.cbxTenLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTenLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTenLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTenLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTenLoai.ForeColor = System.Drawing.Color.Black;
            this.cbxTenLoai.ItemHeight = 45;
            this.cbxTenLoai.Location = new System.Drawing.Point(10, 261);
            this.cbxTenLoai.Name = "cbxTenLoai";
            this.cbxTenLoai.Size = new System.Drawing.Size(256, 51);
            this.cbxTenLoai.TabIndex = 48;
            // 
            // btnChonAnhSP
            // 
            this.btnChonAnhSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChonAnhSP.BorderRadius = 10;
            this.btnChonAnhSP.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnChonAnhSP.BorderThickness = 2;
            this.btnChonAnhSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonAnhSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonAnhSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonAnhSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonAnhSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.btnChonAnhSP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnhSP.ForeColor = System.Drawing.Color.White;
            this.btnChonAnhSP.Location = new System.Drawing.Point(1003, 260);
            this.btnChonAnhSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonAnhSP.Name = "btnChonAnhSP";
            this.btnChonAnhSP.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChonAnhSP.Size = new System.Drawing.Size(220, 51);
            this.btnChonAnhSP.TabIndex = 47;
            this.btnChonAnhSP.Text = "Chọn ảnh";
            this.btnChonAnhSP.Click += new System.EventHandler(this.btnChonAnhSP_Click);
            // 
            // ptbSanPham
            // 
            this.ptbSanPham.FillColor = System.Drawing.Color.Gainsboro;
            this.ptbSanPham.ImageRotate = 0F;
            this.ptbSanPham.Location = new System.Drawing.Point(551, 261);
            this.ptbSanPham.Name = "ptbSanPham";
            this.ptbSanPham.Size = new System.Drawing.Size(447, 409);
            this.ptbSanPham.TabIndex = 46;
            this.ptbSanPham.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(32, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.txtMoTa.BorderRadius = 10;
            this.txtMoTa.BorderThickness = 2;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.ForeColor = System.Drawing.Color.Black;
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Location = new System.Drawing.Point(10, 537);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(535, 133);
            this.txtMoTa.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(294, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Màu sắc";
            // 
            // txtMauSac
            // 
            this.txtMauSac.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.txtMauSac.BorderRadius = 10;
            this.txtMauSac.BorderThickness = 2;
            this.txtMauSac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMauSac.DefaultText = "";
            this.txtMauSac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMauSac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMauSac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMauSac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMauSac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMauSac.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMauSac.ForeColor = System.Drawing.Color.Black;
            this.txtMauSac.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMauSac.Location = new System.Drawing.Point(272, 397);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.PasswordChar = '\0';
            this.txtMauSac.PlaceholderText = "";
            this.txtMauSac.SelectedText = "";
            this.txtMauSac.Size = new System.Drawing.Size(273, 50);
            this.txtMauSac.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(294, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Kích thước";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.txtKichThuoc.BorderRadius = 10;
            this.txtKichThuoc.BorderThickness = 2;
            this.txtKichThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKichThuoc.DefaultText = "";
            this.txtKichThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKichThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKichThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKichThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKichThuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKichThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKichThuoc.ForeColor = System.Drawing.Color.Black;
            this.txtKichThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKichThuoc.Location = new System.Drawing.Point(272, 330);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.PasswordChar = '\0';
            this.txtKichThuoc.PlaceholderText = "";
            this.txtKichThuoc.SelectedText = "";
            this.txtKichThuoc.Size = new System.Drawing.Size(273, 50);
            this.txtKichThuoc.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(294, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.txtGiaBan.BorderRadius = 10;
            this.txtGiaBan.BorderThickness = 2;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.DefaultText = "";
            this.txtGiaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaBan.ForeColor = System.Drawing.Color.Black;
            this.txtGiaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBan.Location = new System.Drawing.Point(272, 261);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.Size = new System.Drawing.Size(273, 50);
            this.txtGiaBan.TabIndex = 38;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(32, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Thương hiệu";
            // 
            // txtThuongHieu
            // 
            this.txtThuongHieu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.txtThuongHieu.BorderRadius = 10;
            this.txtThuongHieu.BorderThickness = 2;
            this.txtThuongHieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThuongHieu.DefaultText = "";
            this.txtThuongHieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThuongHieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThuongHieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThuongHieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThuongHieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThuongHieu.ForeColor = System.Drawing.Color.Black;
            this.txtThuongHieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThuongHieu.Location = new System.Drawing.Point(10, 466);
            this.txtThuongHieu.Name = "txtThuongHieu";
            this.txtThuongHieu.PasswordChar = '\0';
            this.txtThuongHieu.PlaceholderText = "";
            this.txtThuongHieu.SelectedText = "";
            this.txtThuongHieu.Size = new System.Drawing.Size(256, 50);
            this.txtThuongHieu.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(32, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tên Sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.txtTenSP.BorderRadius = 10;
            this.txtTenSP.BorderThickness = 2;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Location = new System.Drawing.Point(10, 399);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(256, 50);
            this.txtTenSP.TabIndex = 34;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnLamMoi.BorderThickness = 2;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(139)))), ((int)(((byte)(81)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(1003, 633);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnLamMoi.Size = new System.Drawing.Size(220, 37);
            this.btnLamMoi.TabIndex = 33;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSua.BorderThickness = 2;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(1003, 585);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnSua.Size = new System.Drawing.Size(220, 37);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(1003, 537);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnXoa.Size = new System.Drawing.Size(220, 37);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnThem.BorderThickness = 2;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(1003, 489);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnThem.Size = new System.Drawing.Size(220, 37);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(32, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.txtMaSP.BorderRadius = 10;
            this.txtMaSP.BorderThickness = 2;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.DefaultText = "";
            this.txtMaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSP.Location = new System.Drawing.Point(10, 330);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PasswordChar = '\0';
            this.txtMaSP.PlaceholderText = "";
            this.txtMaSP.SelectedText = "";
            this.txtMaSP.Size = new System.Drawing.Size(256, 50);
            this.txtMaSP.TabIndex = 3;
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvProducts.Location = new System.Drawing.Point(12, 6);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.Size = new System.Drawing.Size(1211, 236);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProducts.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProducts.ThemeStyle.ReadOnly = false;
            this.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // frmManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 739);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageProducts";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSP;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProducts;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtThuongHieu;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBan;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtMauSac;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtKichThuoc;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2PictureBox ptbSanPham;
        private Guna.UI2.WinForms.Guna2Button btnChonAnhSP;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTenLoai;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2CheckBox ckbTrangThai;
    }
}