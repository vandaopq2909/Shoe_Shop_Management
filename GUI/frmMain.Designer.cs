using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class frmMain
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
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíMànHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNhómNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNhómNgườiDùngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíLoạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phânQuyềnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.toolStripSeparator1,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíNgườiDùngToolStripMenuItem,
            this.quảnLíMànHìnhToolStripMenuItem,
            this.quảnLíNhómNgườiDùngToolStripMenuItem,
            this.quảnLíNhómNgườiDùngToolStripMenuItem1});
            this.phânQuyềnToolStripMenuItem.Enabled = false;
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.phânQuyềnToolStripMenuItem.Text = "Phân quyền";
            this.phânQuyềnToolStripMenuItem.Visible = false;
            // 
            // quảnLíNgườiDùngToolStripMenuItem
            // 
            this.quảnLíNgườiDùngToolStripMenuItem.Enabled = false;
            this.quảnLíNgườiDùngToolStripMenuItem.Name = "quảnLíNgườiDùngToolStripMenuItem";
            this.quảnLíNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.quảnLíNgườiDùngToolStripMenuItem.Tag = "frmNguoiDung";
            this.quảnLíNgườiDùngToolStripMenuItem.Text = "Quản lí người dùng";
            this.quảnLíNgườiDùngToolStripMenuItem.Visible = false;
            // 
            // quảnLíMànHìnhToolStripMenuItem
            // 
            this.quảnLíMànHìnhToolStripMenuItem.Enabled = false;
            this.quảnLíMànHìnhToolStripMenuItem.Name = "quảnLíMànHìnhToolStripMenuItem";
            this.quảnLíMànHìnhToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.quảnLíMànHìnhToolStripMenuItem.Tag = "frmManHinh";
            this.quảnLíMànHìnhToolStripMenuItem.Text = "Quản lí màn hình";
            this.quảnLíMànHìnhToolStripMenuItem.Visible = false;
            // 
            // quảnLíNhómNgườiDùngToolStripMenuItem
            // 
            this.quảnLíNhómNgườiDùngToolStripMenuItem.Enabled = false;
            this.quảnLíNhómNgườiDùngToolStripMenuItem.Name = "quảnLíNhómNgườiDùngToolStripMenuItem";
            this.quảnLíNhómNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.quảnLíNhómNgườiDùngToolStripMenuItem.Tag = "frmNhomManHinh";
            this.quảnLíNhómNgườiDùngToolStripMenuItem.Text = "Quản lí nhóm màn hình";
            this.quảnLíNhómNgườiDùngToolStripMenuItem.Visible = false;
            // 
            // quảnLíNhómNgườiDùngToolStripMenuItem1
            // 
            this.quảnLíNhómNgườiDùngToolStripMenuItem1.Enabled = false;
            this.quảnLíNhómNgườiDùngToolStripMenuItem1.Name = "quảnLíNhómNgườiDùngToolStripMenuItem1";
            this.quảnLíNhómNgườiDùngToolStripMenuItem1.Size = new System.Drawing.Size(262, 26);
            this.quảnLíNhómNgườiDùngToolStripMenuItem1.Tag = "frmNhomNguoiDung";
            this.quảnLíNhómNgườiDùngToolStripMenuItem1.Text = "Quản lí nhóm người dùng";
            this.quảnLíNhómNgườiDùngToolStripMenuItem1.Visible = false;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíLoạiSảnPhẩmToolStripMenuItem,
            this.quảnLíSảnPhẩmToolStripMenuItem,
            this.quảnLíHóaĐơnToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.Enabled = false;
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            this.nghiệpVụToolStripMenuItem.Visible = false;
            // 
            // quảnLíLoạiSảnPhẩmToolStripMenuItem
            // 
            this.quảnLíLoạiSảnPhẩmToolStripMenuItem.Enabled = false;
            this.quảnLíLoạiSảnPhẩmToolStripMenuItem.Name = "quảnLíLoạiSảnPhẩmToolStripMenuItem";
            this.quảnLíLoạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.quảnLíLoạiSảnPhẩmToolStripMenuItem.Tag = "frmLoaiSanPham";
            this.quảnLíLoạiSảnPhẩmToolStripMenuItem.Text = "Quản lí loại sản phẩm";
            this.quảnLíLoạiSảnPhẩmToolStripMenuItem.Visible = false;
            // 
            // quảnLíSảnPhẩmToolStripMenuItem
            // 
            this.quảnLíSảnPhẩmToolStripMenuItem.Enabled = false;
            this.quảnLíSảnPhẩmToolStripMenuItem.Name = "quảnLíSảnPhẩmToolStripMenuItem";
            this.quảnLíSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.quảnLíSảnPhẩmToolStripMenuItem.Tag = "frmSanPham";
            this.quảnLíSảnPhẩmToolStripMenuItem.Text = "Quản lí sản phẩm";
            this.quảnLíSảnPhẩmToolStripMenuItem.Visible = false;
            // 
            // quảnLíHóaĐơnToolStripMenuItem
            // 
            this.quảnLíHóaĐơnToolStripMenuItem.Enabled = false;
            this.quảnLíHóaĐơnToolStripMenuItem.Name = "quảnLíHóaĐơnToolStripMenuItem";
            this.quảnLíHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.quảnLíHóaĐơnToolStripMenuItem.Tag = "frmHoaDon";
            this.quảnLíHóaĐơnToolStripMenuItem.Text = "Quản lí hóa đơn";
            this.quảnLíHóaĐơnToolStripMenuItem.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíMànHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNhómNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNhómNgườiDùngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíLoạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíHóaĐơnToolStripMenuItem;
    }
}