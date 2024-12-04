namespace GUI
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pImage = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.btnDetails = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pImage
            // 
            this.pImage.Image = global::GUI.Properties.Resources.sneakers;
            this.pImage.Location = new System.Drawing.Point(44, 0);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(147, 135);
            this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pImage.TabIndex = 0;
            this.pImage.TabStop = false;
            this.pImage.Click += new System.EventHandler(this.pImage_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(-3, 138);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(235, 68);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(3, 195);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(229, 56);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "190.000đ";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDetails
            // 
            this.btnDetails.AutoRoundedCorners = true;
            this.btnDetails.BorderRadius = 23;
            this.btnDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(44, 254);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(147, 49);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Details";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pImage);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(232, 319);
            this.MouseEnter += new System.EventHandler(this.ucProduct_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucProduct_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private Guna.UI2.WinForms.Guna2GradientButton btnDetails;
    }
}
