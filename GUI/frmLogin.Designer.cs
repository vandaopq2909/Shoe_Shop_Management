namespace GUI
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            ckbShowPass = new CheckBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(311, 61);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 149);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 220);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 2;
            label3.Text = "Mât khẩu";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.Location = new Point(311, 149);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(408, 34);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(311, 223);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(408, 34);
            txtPassword.TabIndex = 4;
            // 
            // ckbShowPass
            // 
            ckbShowPass.AutoSize = true;
            ckbShowPass.Checked = true;
            ckbShowPass.CheckState = CheckState.Checked;
            ckbShowPass.Font = new Font("Segoe UI", 12F);
            ckbShowPass.Location = new Point(311, 287);
            ckbShowPass.Name = "ckbShowPass";
            ckbShowPass.Size = new Size(188, 32);
            ckbShowPass.TabIndex = 5;
            ckbShowPass.Text = "Hiển thị mật khẩu";
            ckbShowPass.UseVisualStyleBackColor = true;
            ckbShowPass.CheckedChanged += ckbShowPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(311, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(154, 52);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.Location = new Point(565, 355);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(154, 52);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Đăng kí";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 485);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(ckbShowPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox ckbShowPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}