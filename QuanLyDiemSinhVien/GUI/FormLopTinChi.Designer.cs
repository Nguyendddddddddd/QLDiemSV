namespace GUI
{
    partial class FormLopTinChi
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
            this.pnlDsLopTC = new Guna.UI2.WinForms.Guna2Panel();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvLopTinChi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnThemLop = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiemLop = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddLopTC = new Guna.UI2.WinForms.Guna2Panel();
            this.clMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuongToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuongSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDsLopTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopTinChi)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDsLopTC
            // 
            this.pnlDsLopTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDsLopTC.BackColor = System.Drawing.Color.Transparent;
            this.pnlDsLopTC.BorderColor = System.Drawing.Color.DimGray;
            this.pnlDsLopTC.BorderRadius = 14;
            this.pnlDsLopTC.BorderThickness = 1;
            this.pnlDsLopTC.Controls.Add(this.cboHocKy);
            this.pnlDsLopTC.Controls.Add(this.dgvLopTinChi);
            this.pnlDsLopTC.Controls.Add(this.btnThemLop);
            this.pnlDsLopTC.Controls.Add(this.guna2Panel1);
            this.pnlDsLopTC.Controls.Add(this.label1);
            this.pnlDsLopTC.FillColor = System.Drawing.Color.White;
            this.pnlDsLopTC.Location = new System.Drawing.Point(14, 14);
            this.pnlDsLopTC.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDsLopTC.Name = "pnlDsLopTC";
            this.pnlDsLopTC.Size = new System.Drawing.Size(1074, 655);
            this.pnlDsLopTC.TabIndex = 4;
            // 
            // cboHocKy
            // 
            this.cboHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cboHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHocKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(711, 24);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(224, 36);
            this.cboHocKy.TabIndex = 10;
            // 
            // dgvLopTinChi
            // 
            this.dgvLopTinChi.AllowUserToAddRows = false;
            this.dgvLopTinChi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLopTinChi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLopTinChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopTinChi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLopTinChi.ColumnHeadersHeight = 18;
            this.dgvLopTinChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLopTinChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaLop,
            this.clMonHoc,
            this.clSoLuongToiDa,
            this.clSoLuongSV,
            this.clNgayBD,
            this.clNgayKT,
            this.clHocKy,
            this.clGiangVien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLopTinChi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLopTinChi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLopTinChi.Location = new System.Drawing.Point(10, 116);
            this.dgvLopTinChi.Name = "dgvLopTinChi";
            this.dgvLopTinChi.RowHeadersVisible = false;
            this.dgvLopTinChi.RowHeadersWidth = 51;
            this.dgvLopTinChi.RowTemplate.Height = 24;
            this.dgvLopTinChi.Size = new System.Drawing.Size(1053, 519);
            this.dgvLopTinChi.TabIndex = 12;
            this.dgvLopTinChi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopTinChi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLopTinChi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLopTinChi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLopTinChi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLopTinChi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopTinChi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLopTinChi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLopTinChi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLopTinChi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLopTinChi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLopTinChi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLopTinChi.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvLopTinChi.ThemeStyle.ReadOnly = false;
            this.dgvLopTinChi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopTinChi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLopTinChi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLopTinChi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLopTinChi.ThemeStyle.RowsStyle.Height = 24;
            this.dgvLopTinChi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLopTinChi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLopTinChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopTinChi_CellClick);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLop.BorderRadius = 8;
            this.btnThemLop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemLop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(939, 19);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(10);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(124, 47);
            this.btnThemLop.TabIndex = 11;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnTimKiemLop);
            this.guna2Panel1.Controls.Add(this.txtTimKiemLop);
            this.guna2Panel1.Location = new System.Drawing.Point(10, 10);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(688, 64);
            this.guna2Panel1.TabIndex = 7;
            // 
            // btnTimKiemLop
            // 
            this.btnTimKiemLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemLop.BorderRadius = 8;
            this.btnTimKiemLop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemLop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemLop.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemLop.Location = new System.Drawing.Point(598, 9);
            this.btnTimKiemLop.Margin = new System.Windows.Forms.Padding(10);
            this.btnTimKiemLop.Name = "btnTimKiemLop";
            this.btnTimKiemLop.Size = new System.Drawing.Size(80, 47);
            this.btnTimKiemLop.TabIndex = 1;
            this.btnTimKiemLop.Text = "Tìm";
            this.btnTimKiemLop.Click += new System.EventHandler(this.btnTimKiemLop_Click);
            // 
            // txtTimKiemLop
            // 
            this.txtTimKiemLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemLop.BorderThickness = 0;
            this.txtTimKiemLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemLop.DefaultText = "";
            this.txtTimKiemLop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemLop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiemLop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemLop.Location = new System.Drawing.Point(16, 4);
            this.txtTimKiemLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemLop.Name = "txtTimKiemLop";
            this.txtTimKiemLop.PasswordChar = '\0';
            this.txtTimKiemLop.PlaceholderText = "Nhập để tìm";
            this.txtTimKiemLop.SelectedText = "";
            this.txtTimKiemLop.Size = new System.Drawing.Size(577, 56);
            this.txtTimKiemLop.TabIndex = 0;
            this.txtTimKiemLop.TextChanged += new System.EventHandler(this.txtTimKiemLop_TextChanged);
            this.txtTimKiemLop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemLop_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(5, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách lớp môn học";
            // 
            // pnlAddLopTC
            // 
            this.pnlAddLopTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddLopTC.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddLopTC.BorderColor = System.Drawing.Color.DimGray;
            this.pnlAddLopTC.BorderRadius = 14;
            this.pnlAddLopTC.BorderThickness = 1;
            this.pnlAddLopTC.FillColor = System.Drawing.Color.White;
            this.pnlAddLopTC.Location = new System.Drawing.Point(792, 14);
            this.pnlAddLopTC.Margin = new System.Windows.Forms.Padding(5);
            this.pnlAddLopTC.Name = "pnlAddLopTC";
            this.pnlAddLopTC.Size = new System.Drawing.Size(296, 655);
            this.pnlAddLopTC.TabIndex = 3;
            this.pnlAddLopTC.Visible = false;
            // 
            // clMaLop
            // 
            this.clMaLop.HeaderText = "Mã lớp";
            this.clMaLop.MinimumWidth = 6;
            this.clMaLop.Name = "clMaLop";
            // 
            // clMonHoc
            // 
            this.clMonHoc.HeaderText = "Môn học";
            this.clMonHoc.MinimumWidth = 6;
            this.clMonHoc.Name = "clMonHoc";
            // 
            // clSoLuongToiDa
            // 
            this.clSoLuongToiDa.HeaderText = "SLTD";
            this.clSoLuongToiDa.MinimumWidth = 6;
            this.clSoLuongToiDa.Name = "clSoLuongToiDa";
            // 
            // clSoLuongSV
            // 
            this.clSoLuongSV.HeaderText = "SLSV";
            this.clSoLuongSV.MinimumWidth = 6;
            this.clSoLuongSV.Name = "clSoLuongSV";
            // 
            // clNgayBD
            // 
            this.clNgayBD.HeaderText = "Ngày bắt đầu";
            this.clNgayBD.MinimumWidth = 6;
            this.clNgayBD.Name = "clNgayBD";
            // 
            // clNgayKT
            // 
            this.clNgayKT.HeaderText = "Ngày kết thúc";
            this.clNgayKT.MinimumWidth = 6;
            this.clNgayKT.Name = "clNgayKT";
            // 
            // clHocKy
            // 
            this.clHocKy.HeaderText = "Học kỳ";
            this.clHocKy.MinimumWidth = 6;
            this.clHocKy.Name = "clHocKy";
            // 
            // clGiangVien
            // 
            this.clGiangVien.HeaderText = "Giảng viên";
            this.clGiangVien.MinimumWidth = 6;
            this.clGiangVien.Name = "clGiangVien";
            // 
            // FormLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.pnlDsLopTC);
            this.Controls.Add(this.pnlAddLopTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLopTinChi";
            this.Text = "FormLopMonHoc";
            this.Load += new System.EventHandler(this.FormLopTinChi_Load);
            this.pnlDsLopTC.ResumeLayout(false);
            this.pnlDsLopTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopTinChi)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlDsLopTC;
        private Guna.UI2.WinForms.Guna2Panel pnlAddLopTC;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemLop;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemLop;
        private Guna.UI2.WinForms.Guna2Button btnThemLop;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLopTinChi;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuongToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuongSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiangVien;
    }
}