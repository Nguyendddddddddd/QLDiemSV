﻿namespace GUI
{
    partial class FormMain
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnKhoaNganh = new Guna.UI2.WinForms.Guna2Button();
            this.btnSinhVien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLop = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Controls.Add(this.btnLop);
            this.guna2Panel1.Controls.Add(this.btnKhoaNganh);
            this.guna2Panel1.Controls.Add(this.btnSinhVien);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(320, 763);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnKhoaNganh
            // 
            this.btnKhoaNganh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoaNganh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoaNganh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhoaNganh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhoaNganh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhoaNganh.ForeColor = System.Drawing.Color.White;
            this.btnKhoaNganh.Location = new System.Drawing.Point(36, 191);
            this.btnKhoaNganh.Name = "btnKhoaNganh";
            this.btnKhoaNganh.Size = new System.Drawing.Size(249, 45);
            this.btnKhoaNganh.TabIndex = 1;
            this.btnKhoaNganh.Text = "Khoa ngành";
            this.btnKhoaNganh.Click += new System.EventHandler(this.btnKhoaNganh_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSinhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnSinhVien.Location = new System.Drawing.Point(36, 140);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(249, 45);
            this.btnSinhVien.TabIndex = 0;
            this.btnSinhVien.Text = "Sinh viên";
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(320, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1102, 80);
            this.guna2Panel2.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(320, 80);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1102, 683);
            this.pnlMain.TabIndex = 2;
            // 
            // btnLop
            // 
            this.btnLop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLop.ForeColor = System.Drawing.Color.White;
            this.btnLop.Location = new System.Drawing.Point(36, 242);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(249, 45);
            this.btnLop.TabIndex = 2;
            this.btnLop.Text = "Lớp";
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 763);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnSinhVien;
        private Guna.UI2.WinForms.Guna2Button btnKhoaNganh;
        private Guna.UI2.WinForms.Guna2Button btnLop;
    }
}