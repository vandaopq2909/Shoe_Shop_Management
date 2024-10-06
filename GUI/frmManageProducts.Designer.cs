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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategoryName = new System.Windows.Forms.ComboBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddPro = new System.Windows.Forms.ToolStripButton();
            this.btnDeletePro = new System.Windows.Forms.ToolStripButton();
            this.btnUpdatePro = new System.Windows.Forms.ToolStripButton();
            this.btnSavePro = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshPro = new System.Windows.Forms.ToolStripButton();
            this.btnExitPro = new System.Windows.Forms.ToolStripButton();
            this.txtBrand = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá bán ";
            // 
            // cbxCategoryName
            // 
            this.cbxCategoryName.FormattingEnabled = true;
            this.cbxCategoryName.Location = new System.Drawing.Point(101, 41);
            this.cbxCategoryName.Name = "cbxCategoryName";
            this.cbxCategoryName.Size = new System.Drawing.Size(192, 21);
            this.cbxCategoryName.TabIndex = 5;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(101, 68);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(192, 20);
            this.txtProductID.TabIndex = 6;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(101, 96);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(192, 20);
            this.txtProductName.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(101, 129);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(192, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thương hiệu";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(562, 41);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(128, 20);
            this.txtImage.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hình ảnh";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(372, 68);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(121, 20);
            this.txtSize.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kích thước";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(562, 68);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(128, 20);
            this.txtColor.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Màu sắc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mô tả";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(372, 99);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(318, 50);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.Text = "";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 155);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(694, 186);
            this.dgvProducts.TabIndex = 19;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPro,
            this.btnDeletePro,
            this.btnUpdatePro,
            this.btnSavePro,
            this.btnRefreshPro,
            this.btnExitPro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 26);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddPro
            // 
            this.btnAddPro.Image = global::GUI.Properties.Resources.plus;
            this.btnAddPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(63, 23);
            this.btnAddPro.Text = "Thêm";
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.Image = global::GUI.Properties.Resources.remove;
            this.btnDeletePro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.Size = new System.Drawing.Size(52, 23);
            this.btnDeletePro.Text = "Xoá";
            this.btnDeletePro.Click += new System.EventHandler(this.btnDeletePro_Click);
            // 
            // btnUpdatePro
            // 
            this.btnUpdatePro.Image = global::GUI.Properties.Resources.pen;
            this.btnUpdatePro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdatePro.Name = "btnUpdatePro";
            this.btnUpdatePro.Size = new System.Drawing.Size(51, 23);
            this.btnUpdatePro.Text = "Sửa";
            this.btnUpdatePro.Click += new System.EventHandler(this.btnUpdatePro_Click);
            // 
            // btnSavePro
            // 
            this.btnSavePro.Image = global::GUI.Properties.Resources.save;
            this.btnSavePro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePro.Name = "btnSavePro";
            this.btnSavePro.Size = new System.Drawing.Size(52, 23);
            this.btnSavePro.Text = "Lưu";
            this.btnSavePro.Click += new System.EventHandler(this.btnSavePro_Click);
            // 
            // btnRefreshPro
            // 
            this.btnRefreshPro.Image = global::GUI.Properties.Resources.refresh;
            this.btnRefreshPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshPro.Name = "btnRefreshPro";
            this.btnRefreshPro.Size = new System.Drawing.Size(74, 23);
            this.btnRefreshPro.Text = "Refresh";
            this.btnRefreshPro.Click += new System.EventHandler(this.btnRefreshPro_Click);
            // 
            // btnExitPro
            // 
            this.btnExitPro.Image = global::GUI.Properties.Resources._switch;
            this.btnExitPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExitPro.Name = "btnExitPro";
            this.btnExitPro.Size = new System.Drawing.Size(63, 23);
            this.btnExitPro.Text = "Đóng";
            this.btnExitPro.Click += new System.EventHandler(this.btnExitPro_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(372, 41);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(121, 20);
            this.txtBrand.TabIndex = 21;
            // 
            // frmManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 353);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.cbxCategoryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmManageProducts";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCategoryName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddPro;
        private System.Windows.Forms.ToolStripButton btnDeletePro;
        private System.Windows.Forms.ToolStripButton btnUpdatePro;
        private System.Windows.Forms.ToolStripButton btnSavePro;
        private System.Windows.Forms.ToolStripButton btnRefreshPro;
        private System.Windows.Forms.ToolStripButton btnExitPro;
        private System.Windows.Forms.TextBox txtBrand;
    }
}