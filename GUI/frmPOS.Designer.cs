namespace GUI
{
    partial class frmPOS
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.panSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panSIze = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox4 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox6 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cboKhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            this.panSIze.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.panLoai);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(29, 102);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(215, 326);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Loại giày";
            // 
            // panLoai
            // 
            this.panLoai.BackColor = System.Drawing.Color.White;
            this.panLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLoai.Location = new System.Drawing.Point(0, 40);
            this.panLoai.Name = "panLoai";
            this.panLoai.Size = new System.Drawing.Size(215, 286);
            this.panLoai.TabIndex = 0;
            // 
            // panSanPham
            // 
            this.panSanPham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panSanPham.Location = new System.Drawing.Point(250, 102);
            this.panSanPham.Name = "panSanPham";
            this.panSanPham.Size = new System.Drawing.Size(729, 794);
            this.panSanPham.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(250, 42);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(729, 51);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1207, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 64);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "LƯU";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1432, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(219, 64);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "XÓA TẤT CẢ";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 50;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(985, 183);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(666, 501);
            this.guna2DataGridView1.TabIndex = 6;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1327, 722);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng Tiền :";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(1481, 722);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(104, 29);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "500.000";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.panSIze);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(29, 434);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(215, 277);
            this.guna2GroupBox3.TabIndex = 9;
            this.guna2GroupBox3.Text = "Size";
            // 
            // panSIze
            // 
            this.panSIze.BackColor = System.Drawing.Color.White;
            this.panSIze.Controls.Add(this.guna2CheckBox1);
            this.panSIze.Controls.Add(this.guna2CheckBox2);
            this.panSIze.Controls.Add(this.guna2CheckBox3);
            this.panSIze.Controls.Add(this.guna2CheckBox4);
            this.panSIze.Controls.Add(this.guna2CheckBox5);
            this.panSIze.Controls.Add(this.guna2CheckBox6);
            this.panSIze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSIze.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panSIze.Location = new System.Drawing.Point(0, 40);
            this.panSIze.Name = "panSIze";
            this.panSIze.Size = new System.Drawing.Size(215, 237);
            this.panSIze.TabIndex = 0;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(47, 24);
            this.guna2CheckBox1.TabIndex = 0;
            this.guna2CheckBox1.Text = "38";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 0;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.Location = new System.Drawing.Point(3, 33);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(47, 24);
            this.guna2CheckBox2.TabIndex = 1;
            this.guna2CheckBox2.Text = "39";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox3
            // 
            this.guna2CheckBox3.AutoSize = true;
            this.guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox3.CheckedState.BorderRadius = 0;
            this.guna2CheckBox3.CheckedState.BorderThickness = 0;
            this.guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox3.Location = new System.Drawing.Point(3, 63);
            this.guna2CheckBox3.Name = "guna2CheckBox3";
            this.guna2CheckBox3.Size = new System.Drawing.Size(47, 24);
            this.guna2CheckBox3.TabIndex = 2;
            this.guna2CheckBox3.Text = "40";
            this.guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox3.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox3.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox4
            // 
            this.guna2CheckBox4.AutoSize = true;
            this.guna2CheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox4.CheckedState.BorderRadius = 0;
            this.guna2CheckBox4.CheckedState.BorderThickness = 0;
            this.guna2CheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox4.Location = new System.Drawing.Point(3, 93);
            this.guna2CheckBox4.Name = "guna2CheckBox4";
            this.guna2CheckBox4.Size = new System.Drawing.Size(47, 24);
            this.guna2CheckBox4.TabIndex = 3;
            this.guna2CheckBox4.Text = "41";
            this.guna2CheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox4.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox4.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox5
            // 
            this.guna2CheckBox5.AutoSize = true;
            this.guna2CheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox5.CheckedState.BorderRadius = 0;
            this.guna2CheckBox5.CheckedState.BorderThickness = 0;
            this.guna2CheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox5.Location = new System.Drawing.Point(3, 123);
            this.guna2CheckBox5.Name = "guna2CheckBox5";
            this.guna2CheckBox5.Size = new System.Drawing.Size(47, 24);
            this.guna2CheckBox5.TabIndex = 4;
            this.guna2CheckBox5.Text = "42";
            this.guna2CheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox5.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox5.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox6
            // 
            this.guna2CheckBox6.AutoSize = true;
            this.guna2CheckBox6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox6.CheckedState.BorderRadius = 0;
            this.guna2CheckBox6.CheckedState.BorderThickness = 0;
            this.guna2CheckBox6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox6.Location = new System.Drawing.Point(3, 153);
            this.guna2CheckBox6.Name = "guna2CheckBox6";
            this.guna2CheckBox6.Size = new System.Drawing.Size(47, 24);
            this.guna2CheckBox6.TabIndex = 5;
            this.guna2CheckBox6.Text = "43";
            this.guna2CheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox6.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox6.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cboKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhachHang.ItemHeight = 30;
            this.cboKhachHang.Location = new System.Drawing.Point(1265, 116);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(386, 36);
            this.cboKhachHang.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1045, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chọn khách hàng";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 938);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.panSanPham);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.panSIze.ResumeLayout(false);
            this.panSIze.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.FlowLayoutPanel panSanPham;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.FlowLayoutPanel panLoai;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.FlowLayoutPanel panSIze;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox4;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox5;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox6;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}