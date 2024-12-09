namespace GUI
{
    partial class frmManageCategories
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
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLamMoiLoai = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaLoai = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaLoai = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemLoai = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvCategories = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 23);
            this.btnAdd.Text = "Thêm";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 23);
            this.btnDelete.Text = "Xoá";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(51, 23);
            this.btnUpdate.Text = "Sửa";
            // 
            // btnSave
            // 
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 23);
            this.btnSave.Text = "Lưu";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 23);
            this.btnRefresh.Text = "Refresh";
            // 
            // btnExit
            // 
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 23);
            this.btnExit.Text = "Đóng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách Loại sản phẩm";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "Tìm kiếm loại sản phẩm...";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::GUI.Properties.Resources.search;
            this.txtSearch.Location = new System.Drawing.Point(856, 7);
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
            this.panel2.Controls.Add(this.btnLamMoiLoai);
            this.panel2.Controls.Add(this.btnSuaLoai);
            this.panel2.Controls.Add(this.btnXoaLoai);
            this.panel2.Controls.Add(this.btnThemLoai);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTenLoai);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaLoai);
            this.panel2.Controls.Add(this.dgvCategories);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 682);
            this.panel2.TabIndex = 2;
            // 
            // btnLamMoiLoai
            // 
            this.btnLamMoiLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnLamMoiLoai.BorderRadius = 10;
            this.btnLamMoiLoai.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnLamMoiLoai.BorderThickness = 2;
            this.btnLamMoiLoai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiLoai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoiLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoiLoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(139)))), ((int)(((byte)(81)))));
            this.btnLamMoiLoai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiLoai.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoiLoai.Location = new System.Drawing.Point(653, 634);
            this.btnLamMoiLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoiLoai.Name = "btnLamMoiLoai";
            this.btnLamMoiLoai.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnLamMoiLoai.Size = new System.Drawing.Size(169, 37);
            this.btnLamMoiLoai.TabIndex = 33;
            this.btnLamMoiLoai.Text = "Làm mới";
            this.btnLamMoiLoai.Click += new System.EventHandler(this.btnLamMoiLoai_Click);
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnSuaLoai.BorderRadius = 10;
            this.btnSuaLoai.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSuaLoai.BorderThickness = 2;
            this.btnSuaLoai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaLoai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaLoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnSuaLoai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoai.ForeColor = System.Drawing.Color.Black;
            this.btnSuaLoai.Location = new System.Drawing.Point(469, 634);
            this.btnSuaLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnSuaLoai.Size = new System.Drawing.Size(169, 37);
            this.btnSuaLoai.TabIndex = 32;
            this.btnSuaLoai.Text = "Sửa";
            this.btnSuaLoai.Click += new System.EventHandler(this.btnSuaLoai_Click);
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnXoaLoai.BorderRadius = 10;
            this.btnXoaLoai.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnXoaLoai.BorderThickness = 2;
            this.btnXoaLoai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaLoai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaLoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnXoaLoai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoai.ForeColor = System.Drawing.Color.Black;
            this.btnXoaLoai.Location = new System.Drawing.Point(653, 582);
            this.btnXoaLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnXoaLoai.Size = new System.Drawing.Size(169, 37);
            this.btnXoaLoai.TabIndex = 30;
            this.btnXoaLoai.Text = "Xoá";
            this.btnXoaLoai.Click += new System.EventHandler(this.btnXoaLoai_Click);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnThemLoai.BorderRadius = 10;
            this.btnThemLoai.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnThemLoai.BorderThickness = 2;
            this.btnThemLoai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemLoai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemLoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(191)))));
            this.btnThemLoai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoai.ForeColor = System.Drawing.Color.Black;
            this.btnThemLoai.Location = new System.Drawing.Point(469, 582);
            this.btnThemLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.btnThemLoai.Size = new System.Drawing.Size(169, 37);
            this.btnThemLoai.TabIndex = 29;
            this.btnThemLoai.Text = "Thêm";
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(321, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Loại";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.txtTenLoai.BorderRadius = 10;
            this.txtTenLoai.BorderThickness = 2;
            this.txtTenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoai.DefaultText = "";
            this.txtTenLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLoai.ForeColor = System.Drawing.Color.Black;
            this.txtTenLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoai.Location = new System.Drawing.Point(299, 492);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.PasswordChar = '\0';
            this.txtTenLoai.PlaceholderText = "";
            this.txtTenLoai.SelectedText = "";
            this.txtTenLoai.Size = new System.Drawing.Size(696, 50);
            this.txtTenLoai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(321, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Loại";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            this.txtMaLoai.BorderRadius = 10;
            this.txtMaLoai.BorderThickness = 2;
            this.txtMaLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoai.DefaultText = "";
            this.txtMaLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLoai.ForeColor = System.Drawing.Color.Black;
            this.txtMaLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoai.Location = new System.Drawing.Point(299, 406);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.PasswordChar = '\0';
            this.txtMaLoai.PlaceholderText = "";
            this.txtMaLoai.SelectedText = "";
            this.txtMaLoai.Size = new System.Drawing.Size(696, 50);
            this.txtMaLoai.TabIndex = 1;
            // 
            // dgvCategories
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(113)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCategories.ColumnHeadersHeight = 40;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvCategories.Location = new System.Drawing.Point(12, 6);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.Size = new System.Drawing.Size(1210, 371);
            this.dgvCategories.TabIndex = 0;
            this.dgvCategories.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dgvCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.dgvCategories.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCategories.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.dgvCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.dgvCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategories.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCategories.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCategories.ThemeStyle.ReadOnly = false;
            this.dgvCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.dgvCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCategories.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.dgvCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellClick);
            // 
            // frmManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 739);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageCategories";
            this.Text = "Quản lý loại sản phẩm";
            this.Load += new System.EventHandler(this.frmManageCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnLamMoiLoai;
        private Guna.UI2.WinForms.Guna2Button btnSuaLoai;
        private Guna.UI2.WinForms.Guna2Button btnXoaLoai;
        private Guna.UI2.WinForms.Guna2Button btnThemLoai;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoai;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLoai;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategories;
    }
}