namespace GUI
{
    partial class FormChiTietLopHoc
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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSinhVienLopHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaSinhVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemLop = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiemLop = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSide = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienLopHoc)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderColor = System.Drawing.Color.DimGray;
            this.pnlMain.BorderRadius = 14;
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Controls.Add(this.dgvSinhVienLopHoc);
            this.pnlMain.Controls.Add(this.btnXoaSinhVien);
            this.pnlMain.Controls.Add(this.btnThemLop);
            this.pnlMain.Controls.Add(this.guna2Panel1);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(14, 364);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1074, 305);
            this.pnlMain.TabIndex = 6;
            // 
            // dgvSinhVienLopHoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSinhVienLopHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSinhVienLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSinhVienLopHoc.ColumnHeadersHeight = 18;
            this.dgvSinhVienLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSinhVienLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSV,
            this.clTenSinhVien,
            this.clNgaySinh,
            this.clLop,
            this.clKhoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSinhVienLopHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSinhVienLopHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSinhVienLopHoc.Location = new System.Drawing.Point(18, 125);
            this.dgvSinhVienLopHoc.Name = "dgvSinhVienLopHoc";
            this.dgvSinhVienLopHoc.RowHeadersVisible = false;
            this.dgvSinhVienLopHoc.RowHeadersWidth = 51;
            this.dgvSinhVienLopHoc.RowTemplate.Height = 24;
            this.dgvSinhVienLopHoc.Size = new System.Drawing.Size(1039, 177);
            this.dgvSinhVienLopHoc.TabIndex = 14;
            this.dgvSinhVienLopHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSinhVienLopHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSinhVienLopHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSinhVienLopHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSinhVienLopHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSinhVienLopHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSinhVienLopHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSinhVienLopHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSinhVienLopHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSinhVienLopHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSinhVienLopHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSinhVienLopHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSinhVienLopHoc.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvSinhVienLopHoc.ThemeStyle.ReadOnly = false;
            this.dgvSinhVienLopHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSinhVienLopHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSinhVienLopHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSinhVienLopHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSinhVienLopHoc.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSinhVienLopHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSinhVienLopHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clMaSV
            // 
            this.clMaSV.HeaderText = "Mã số sinh viên";
            this.clMaSV.MinimumWidth = 6;
            this.clMaSV.Name = "clMaSV";
            // 
            // clTenSinhVien
            // 
            this.clTenSinhVien.HeaderText = "Họ tên ";
            this.clTenSinhVien.MinimumWidth = 6;
            this.clTenSinhVien.Name = "clTenSinhVien";
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.HeaderText = "Ngày sinh";
            this.clNgaySinh.MinimumWidth = 6;
            this.clNgaySinh.Name = "clNgaySinh";
            // 
            // clLop
            // 
            this.clLop.HeaderText = "Lớp";
            this.clLop.MinimumWidth = 6;
            this.clLop.Name = "clLop";
            // 
            // clKhoa
            // 
            this.clKhoa.HeaderText = "Khoa";
            this.clKhoa.MinimumWidth = 6;
            this.clKhoa.Name = "clKhoa";
            // 
            // btnXoaSinhVien
            // 
            this.btnXoaSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaSinhVien.BorderRadius = 8;
            this.btnXoaSinhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSinhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnXoaSinhVien.Location = new System.Drawing.Point(917, 19);
            this.btnXoaSinhVien.Margin = new System.Windows.Forms.Padding(10);
            this.btnXoaSinhVien.Name = "btnXoaSinhVien";
            this.btnXoaSinhVien.Size = new System.Drawing.Size(140, 47);
            this.btnXoaSinhVien.TabIndex = 13;
            this.btnXoaSinhVien.Text = "Xóa sinh viên";
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
            this.btnThemLop.Location = new System.Drawing.Point(757, 19);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(10);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(140, 47);
            this.btnThemLop.TabIndex = 11;
            this.btnThemLop.Text = "Thêm sinh viên";
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
            this.guna2Panel1.Location = new System.Drawing.Point(18, 10);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách sinh viên lớp học";
            // 
            // pnlSide
            // 
            this.pnlSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSide.BackColor = System.Drawing.Color.Transparent;
            this.pnlSide.BorderColor = System.Drawing.Color.DimGray;
            this.pnlSide.BorderRadius = 14;
            this.pnlSide.BorderThickness = 1;
            this.pnlSide.FillColor = System.Drawing.Color.White;
            this.pnlSide.Location = new System.Drawing.Point(792, 14);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(296, 655);
            this.pnlSide.TabIndex = 5;
            this.pnlSide.Visible = false;
            // 
            // FormChiTietLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTietLopHoc";
            this.Text = "FormChiTietLopHoc";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienLopHoc)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnThemLop;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemLop;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemLop;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnlSide;
        private Guna.UI2.WinForms.Guna2Button btnXoaSinhVien;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSinhVienLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhoa;
    }
}