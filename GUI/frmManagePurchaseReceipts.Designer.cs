namespace GUI
{
    partial class frmManagePurchaseReceipts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoiPN = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaPN = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaPN = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemPN = new Guna.UI2.WinForms.Guna2Button();
            this.dtpNgayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvPR = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboChonSP = new System.Windows.Forms.ComboBox();
            this.dgvPRDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.numSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPR)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1645, 70);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Nhập Hàng";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::GUI.Properties.Resources.search;
            this.txtSearch.Location = new System.Drawing.Point(901, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm kiếm phiếu nhập";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(501, 58);
            this.txtSearch.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(702, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.numSoLuong);
            this.panel2.Controls.Add(this.cboChonSP);
            this.panel2.Controls.Add(this.btnXoaSP);
            this.panel2.Controls.Add(this.btnThemSP);
            this.panel2.Controls.Add(this.btnLamMoiPN);
            this.panel2.Controls.Add(this.btnXoaPN);
            this.panel2.Controls.Add(this.btnSuaPN);
            this.panel2.Controls.Add(this.btnThemPN);
            this.panel2.Controls.Add(this.dtpNgayNhap);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboNCC);
            this.panel2.Controls.Add(this.guna2GroupBox2);
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1645, 840);
            this.panel2.TabIndex = 3;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnXoaSP.BorderRadius = 10;
            this.btnXoaSP.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnXoaSP.BorderThickness = 2;
            this.btnXoaSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.Black;
            this.btnXoaSP.Location = new System.Drawing.Point(1178, 475);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnXoaSP.Size = new System.Drawing.Size(234, 51);
            this.btnXoaSP.TabIndex = 58;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnThemSP.BorderRadius = 10;
            this.btnThemSP.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnThemSP.BorderThickness = 2;
            this.btnThemSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.Black;
            this.btnThemSP.Location = new System.Drawing.Point(910, 475);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnThemSP.Size = new System.Drawing.Size(234, 51);
            this.btnThemSP.TabIndex = 60;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnLamMoiPN
            // 
            this.btnLamMoiPN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnLamMoiPN.BorderRadius = 10;
            this.btnLamMoiPN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnLamMoiPN.BorderThickness = 2;
            this.btnLamMoiPN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiPN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoiPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoiPN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(139)))), ((int)(((byte)(81)))));
            this.btnLamMoiPN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiPN.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoiPN.Location = new System.Drawing.Point(1140, 106);
            this.btnLamMoiPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoiPN.Name = "btnLamMoiPN";
            this.btnLamMoiPN.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnLamMoiPN.Size = new System.Drawing.Size(260, 59);
            this.btnLamMoiPN.TabIndex = 57;
            this.btnLamMoiPN.Text = "Làm mới phiếu nhập";
            this.btnLamMoiPN.Click += new System.EventHandler(this.btnLamMoiPN_Click);
            // 
            // btnXoaPN
            // 
            this.btnXoaPN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnXoaPN.BorderRadius = 10;
            this.btnXoaPN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnXoaPN.BorderThickness = 2;
            this.btnXoaPN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaPN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaPN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnXoaPN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPN.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPN.Location = new System.Drawing.Point(766, 106);
            this.btnXoaPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPN.Name = "btnXoaPN";
            this.btnXoaPN.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnXoaPN.Size = new System.Drawing.Size(260, 59);
            this.btnXoaPN.TabIndex = 54;
            this.btnXoaPN.Text = "Xóa phiếu nhập";
            this.btnXoaPN.Click += new System.EventHandler(this.btnXoaPN_Click);
            // 
            // btnSuaPN
            // 
            this.btnSuaPN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnSuaPN.BorderRadius = 10;
            this.btnSuaPN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSuaPN.BorderThickness = 2;
            this.btnSuaPN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaPN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaPN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnSuaPN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPN.ForeColor = System.Drawing.Color.Black;
            this.btnSuaPN.Location = new System.Drawing.Point(392, 106);
            this.btnSuaPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaPN.Name = "btnSuaPN";
            this.btnSuaPN.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnSuaPN.Size = new System.Drawing.Size(260, 59);
            this.btnSuaPN.TabIndex = 55;
            this.btnSuaPN.Text = "Sửa phiếu nhập";
            this.btnSuaPN.Click += new System.EventHandler(this.btnSuaPN_Click);
            // 
            // btnThemPN
            // 
            this.btnThemPN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnThemPN.BorderRadius = 10;
            this.btnThemPN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnThemPN.BorderThickness = 2;
            this.btnThemPN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemPN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnThemPN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPN.ForeColor = System.Drawing.Color.Black;
            this.btnThemPN.Location = new System.Drawing.Point(18, 106);
            this.btnThemPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnThemPN.Size = new System.Drawing.Size(260, 59);
            this.btnThemPN.TabIndex = 56;
            this.btnThemPN.Text = "Thêm phiếu nhập";
            this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.BackColor = System.Drawing.SystemColors.Control;
            this.dtpNgayNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.dtpNgayNhap.BorderRadius = 10;
            this.dtpNgayNhap.BorderThickness = 2;
            this.dtpNgayNhap.Checked = true;
            this.dtpNgayNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dtpNgayNhap.FillColor = System.Drawing.Color.White;
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayNhap.Location = new System.Drawing.Point(853, 16);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(549, 51);
            this.dtpNgayNhap.TabIndex = 52;
            this.dtpNgayNhap.Value = new System.DateTime(2024, 11, 20, 13, 50, 31, 229);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nhà cung cấp";
            // 
            // cboNCC
            // 
            this.cboNCC.BackColor = System.Drawing.Color.Transparent;
            this.cboNCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.cboNCC.BorderRadius = 10;
            this.cboNCC.BorderThickness = 2;
            this.cboNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNCC.ForeColor = System.Drawing.Color.Black;
            this.cboNCC.ItemHeight = 45;
            this.cboNCC.Location = new System.Drawing.Point(221, 15);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(399, 51);
            this.cboNCC.TabIndex = 50;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Controls.Add(this.dgvPR);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(5, 177);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1637, 280);
            this.guna2GroupBox2.TabIndex = 5;
            this.guna2GroupBox2.Text = "Phiếu nhập";
            // 
            // dgvPR
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvPR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPR.ColumnHeadersHeight = 40;
            this.dgvPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPR.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvPR.Location = new System.Drawing.Point(0, 40);
            this.dgvPR.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPR.Name = "dgvPR";
            this.dgvPR.ReadOnly = true;
            this.dgvPR.RowHeadersVisible = false;
            this.dgvPR.RowHeadersWidth = 51;
            this.dgvPR.Size = new System.Drawing.Size(1637, 240);
            this.dgvPR.TabIndex = 34;
            this.dgvPR.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dgvPR.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvPR.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPR.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPR.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPR.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPR.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvPR.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvPR.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvPR.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPR.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvPR.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPR.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPR.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPR.ThemeStyle.ReadOnly = true;
            this.dgvPR.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvPR.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPR.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvPR.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPR.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPR.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvPR.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPR_CellClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Controls.Add(this.dgvPRDetail);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(5, 547);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1637, 293);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Chi tiết phiếu nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(13, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "Sản phẩm";
            // 
            // cboChonSP
            // 
            this.cboChonSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboChonSP.FormattingEnabled = true;
            this.cboChonSP.Location = new System.Drawing.Point(141, 478);
            this.cboChonSP.Name = "cboChonSP";
            this.cboChonSP.Size = new System.Drawing.Size(406, 44);
            this.cboChonSP.TabIndex = 62;
            // 
            // dgvPRDetail
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvPRDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPRDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPRDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPRDetail.ColumnHeadersHeight = 40;
            this.dgvPRDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPRDetail.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPRDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPRDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvPRDetail.Location = new System.Drawing.Point(0, 40);
            this.dgvPRDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPRDetail.Name = "dgvPRDetail";
            this.dgvPRDetail.ReadOnly = true;
            this.dgvPRDetail.RowHeadersVisible = false;
            this.dgvPRDetail.RowHeadersWidth = 51;
            this.dgvPRDetail.Size = new System.Drawing.Size(1637, 253);
            this.dgvPRDetail.TabIndex = 35;
            this.dgvPRDetail.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dgvPRDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvPRDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPRDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPRDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPRDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPRDetail.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvPRDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvPRDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvPRDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPRDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvPRDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPRDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPRDetail.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPRDetail.ThemeStyle.ReadOnly = true;
            this.dgvPRDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvPRDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPRDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvPRDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPRDetail.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPRDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvPRDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPRDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRDetail_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(607, 486);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 29);
            this.label10.TabIndex = 64;
            this.label10.Text = "Số lượng";
            // 
            // numSoLuong
            // 
            this.numSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.numSoLuong.BorderRadius = 5;
            this.numSoLuong.BorderThickness = 2;
            this.numSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSoLuong.Location = new System.Drawing.Point(724, 477);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(139, 47);
            this.numSoLuong.TabIndex = 63;
            this.numSoLuong.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.numSoLuong.UpDownButtonForeColor = System.Drawing.Color.White;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmManagePurchaseReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 910);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagePurchaseReceipts";
            this.Text = "frmManagePurchaseReceipts";
            this.Load += new System.EventHandler(this.frmManagePurchaseReceipts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPR)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cboNCC;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhap;
        private Guna.UI2.WinForms.Guna2Button btnLamMoiPN;
        private Guna.UI2.WinForms.Guna2Button btnXoaPN;
        private Guna.UI2.WinForms.Guna2Button btnSuaPN;
        private Guna.UI2.WinForms.Guna2Button btnThemPN;
        private Guna.UI2.WinForms.Guna2Button btnXoaSP;
        private Guna.UI2.WinForms.Guna2Button btnThemSP;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboChonSP;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPRDetail;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuong;
    }
}