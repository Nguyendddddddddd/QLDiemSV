namespace GUI
{
    partial class FormGiangVien
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
            this.pnlDsGiangVien = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvGiangVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMSGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocHam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiemGiangVien = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemTenGiangVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemGiangVien = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAddGiangVien = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDsGiangVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDsGiangVien
            // 
            this.pnlDsGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDsGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.pnlDsGiangVien.BorderColor = System.Drawing.Color.DimGray;
            this.pnlDsGiangVien.BorderRadius = 14;
            this.pnlDsGiangVien.BorderThickness = 1;
            this.pnlDsGiangVien.Controls.Add(this.dgvGiangVien);
            this.pnlDsGiangVien.Controls.Add(this.guna2Panel1);
            this.pnlDsGiangVien.Controls.Add(this.btnThemGiangVien);
            this.pnlDsGiangVien.FillColor = System.Drawing.Color.White;
            this.pnlDsGiangVien.Location = new System.Drawing.Point(14, 14);
            this.pnlDsGiangVien.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDsGiangVien.Name = "pnlDsGiangVien";
            this.pnlDsGiangVien.Size = new System.Drawing.Size(1074, 656);
            this.pnlDsGiangVien.TabIndex = 4;
            // 
            // dgvGiangVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvGiangVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiangVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiangVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiangVien.ColumnHeadersHeight = 18;
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMSGV,
            this.clHoLot,
            this.clTenGV,
            this.clGioiTinh,
            this.clNgaySinh,
            this.clHocHam,
            this.clHocVi,
            this.CLChuyenMon,
            this.ClMaKhoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiangVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGiangVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiangVien.Location = new System.Drawing.Point(23, 83);
            this.dgvGiangVien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.RowHeadersVisible = false;
            this.dgvGiangVien.RowHeadersWidth = 51;
            this.dgvGiangVien.RowTemplate.Height = 24;
            this.dgvGiangVien.Size = new System.Drawing.Size(1034, 522);
            this.dgvGiangVien.TabIndex = 7;
            this.dgvGiangVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiangVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGiangVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGiangVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGiangVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGiangVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiangVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiangVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvGiangVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGiangVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGiangVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGiangVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGiangVien.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvGiangVien.ThemeStyle.ReadOnly = false;
            this.dgvGiangVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiangVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiangVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGiangVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGiangVien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvGiangVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiangVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellClick);
            // 
            // clMSGV
            // 
            this.clMSGV.HeaderText = "Mã giảng viên";
            this.clMSGV.MinimumWidth = 6;
            this.clMSGV.Name = "clMSGV";
            // 
            // clHoLot
            // 
            this.clHoLot.HeaderText = "Họ lót";
            this.clHoLot.MinimumWidth = 6;
            this.clHoLot.Name = "clHoLot";
            // 
            // clTenGV
            // 
            this.clTenGV.HeaderText = "Họ tên";
            this.clTenGV.MinimumWidth = 6;
            this.clTenGV.Name = "clTenGV";
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.HeaderText = "Giới tính";
            this.clGioiTinh.MinimumWidth = 6;
            this.clGioiTinh.Name = "clGioiTinh";
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.HeaderText = "Ngày sinh";
            this.clNgaySinh.MinimumWidth = 6;
            this.clNgaySinh.Name = "clNgaySinh";
            // 
            // clHocHam
            // 
            this.clHocHam.HeaderText = "Học hàm";
            this.clHocHam.MinimumWidth = 6;
            this.clHocHam.Name = "clHocHam";
            // 
            // clHocVi
            // 
            this.clHocVi.HeaderText = "Học vị";
            this.clHocVi.MinimumWidth = 6;
            this.clHocVi.Name = "clHocVi";
            // 
            // CLChuyenMon
            // 
            this.CLChuyenMon.HeaderText = "Chuyên môn";
            this.CLChuyenMon.MinimumWidth = 8;
            this.CLChuyenMon.Name = "CLChuyenMon";
            // 
            // ClMaKhoa
            // 
            this.ClMaKhoa.HeaderText = "Mã khoa";
            this.ClMaKhoa.MinimumWidth = 8;
            this.ClMaKhoa.Name = "ClMaKhoa";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnTimKiemGiangVien);
            this.guna2Panel1.Controls.Add(this.txtTimKiemTenGiangVien);
            this.guna2Panel1.Location = new System.Drawing.Point(23, 10);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(846, 62);
            this.guna2Panel1.TabIndex = 6;
            // 
            // btnTimKiemGiangVien
            // 
            this.btnTimKiemGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemGiangVien.BorderRadius = 8;
            this.btnTimKiemGiangVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemGiangVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemGiangVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemGiangVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemGiangVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemGiangVien.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemGiangVien.Location = new System.Drawing.Point(750, 9);
            this.btnTimKiemGiangVien.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnTimKiemGiangVien.Name = "btnTimKiemGiangVien";
            this.btnTimKiemGiangVien.Size = new System.Drawing.Size(85, 45);
            this.btnTimKiemGiangVien.TabIndex = 1;
            this.btnTimKiemGiangVien.Text = "Tìm";
            this.btnTimKiemGiangVien.Click += new System.EventHandler(this.btnTimKiemGiangVien_Click);
            // 
            // txtTimKiemTenGiangVien
            // 
            this.txtTimKiemTenGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemTenGiangVien.BorderThickness = 0;
            this.txtTimKiemTenGiangVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemTenGiangVien.DefaultText = "";
            this.txtTimKiemTenGiangVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemTenGiangVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemTenGiangVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemTenGiangVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemTenGiangVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemTenGiangVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiemTenGiangVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemTenGiangVien.Location = new System.Drawing.Point(17, 4);
            this.txtTimKiemTenGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemTenGiangVien.Name = "txtTimKiemTenGiangVien";
            this.txtTimKiemTenGiangVien.PasswordChar = '\0';
            this.txtTimKiemTenGiangVien.PlaceholderText = "Nhập tên giảng viên hoặc mã số giảng viên để tìm";
            this.txtTimKiemTenGiangVien.SelectedText = "";
            this.txtTimKiemTenGiangVien.Size = new System.Drawing.Size(733, 54);
            this.txtTimKiemTenGiangVien.TabIndex = 0;
            this.txtTimKiemTenGiangVien.TextChanged += new System.EventHandler(this.txtTimKiemTenGiangVien_TextChanged);
            this.txtTimKiemTenGiangVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemTenGiangVien_KeyDown);
            // 
            // btnThemGiangVien
            // 
            this.btnThemGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemGiangVien.BorderRadius = 14;
            this.btnThemGiangVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemGiangVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemGiangVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemGiangVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemGiangVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemGiangVien.ForeColor = System.Drawing.Color.White;
            this.btnThemGiangVien.Location = new System.Drawing.Point(884, 10);
            this.btnThemGiangVien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemGiangVien.Name = "btnThemGiangVien";
            this.btnThemGiangVien.Size = new System.Drawing.Size(174, 62);
            this.btnThemGiangVien.TabIndex = 0;
            this.btnThemGiangVien.Text = "Thêm giảng viên";
            this.btnThemGiangVien.Click += new System.EventHandler(this.btnThemGiangVien_Click);
            // 
            // pnlAddGiangVien
            // 
            this.pnlAddGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddGiangVien.BorderColor = System.Drawing.Color.DimGray;
            this.pnlAddGiangVien.BorderRadius = 14;
            this.pnlAddGiangVien.BorderThickness = 1;
            this.pnlAddGiangVien.FillColor = System.Drawing.Color.White;
            this.pnlAddGiangVien.Location = new System.Drawing.Point(771, 14);
            this.pnlAddGiangVien.Margin = new System.Windows.Forms.Padding(5);
            this.pnlAddGiangVien.Name = "pnlAddGiangVien";
            this.pnlAddGiangVien.Size = new System.Drawing.Size(316, 656);
            this.pnlAddGiangVien.TabIndex = 3;
            this.pnlAddGiangVien.Visible = false;
            // 
            // FormGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.pnlDsGiangVien);
            this.Controls.Add(this.pnlAddGiangVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGiangVien";
            this.Text = "FormGiangVien";
            this.Load += new System.EventHandler(this.FormGiangVien_Load);
            this.pnlDsGiangVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlDsGiangVien;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemGiangVien;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemTenGiangVien;
        private Guna.UI2.WinForms.Guna2Button btnThemGiangVien;
        private Guna.UI2.WinForms.Guna2Panel pnlAddGiangVien;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMSGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocHam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMaKhoa;
    }
}