namespace GUI
{
    partial class FormSinhVien
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
            this.pnlAddSinhVien = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDsSinhVien = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiemSinhVien = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemTenSinhVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemSinhVien = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDsSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddSinhVien
            // 
            this.pnlAddSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddSinhVien.BorderColor = System.Drawing.Color.DimGray;
            this.pnlAddSinhVien.BorderRadius = 14;
            this.pnlAddSinhVien.BorderThickness = 1;
            this.pnlAddSinhVien.FillColor = System.Drawing.Color.White;
            this.pnlAddSinhVien.Location = new System.Drawing.Point(792, 14);
            this.pnlAddSinhVien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlAddSinhVien.Name = "pnlAddSinhVien";
            this.pnlAddSinhVien.Size = new System.Drawing.Size(296, 655);
            this.pnlAddSinhVien.TabIndex = 1;
            this.pnlAddSinhVien.Visible = false;
            // 
            // pnlDsSinhVien
            // 
            this.pnlDsSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDsSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.pnlDsSinhVien.BorderColor = System.Drawing.Color.DimGray;
            this.pnlDsSinhVien.BorderRadius = 14;
            this.pnlDsSinhVien.BorderThickness = 1;
            this.pnlDsSinhVien.Controls.Add(this.dgvSinhVien);
            this.pnlDsSinhVien.Controls.Add(this.guna2Panel1);
            this.pnlDsSinhVien.Controls.Add(this.btnThemSinhVien);
            this.pnlDsSinhVien.FillColor = System.Drawing.Color.White;
            this.pnlDsSinhVien.Location = new System.Drawing.Point(14, 14);
            this.pnlDsSinhVien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlDsSinhVien.Name = "pnlDsSinhVien";
            this.pnlDsSinhVien.Size = new System.Drawing.Size(1074, 655);
            this.pnlDsSinhVien.TabIndex = 2;
            // 
            // dgvSinhVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSinhVien.ColumnHeadersHeight = 18;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMSSV,
            this.clHoLot,
            this.clTenSV,
            this.clGioiTinh,
            this.clNgaySinh,
            this.clDiaChi,
            this.clLop});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSinhVien.Location = new System.Drawing.Point(22, 87);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(1037, 543);
            this.dgvSinhVien.TabIndex = 7;
            this.dgvSinhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSinhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSinhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSinhVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSinhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSinhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSinhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSinhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSinhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSinhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSinhVien.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvSinhVien.ThemeStyle.ReadOnly = false;
            this.dgvSinhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSinhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSinhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSinhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSinhVien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSinhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSinhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvSinhVien_CellClick);
            // 
            // clMSSV
            // 
            this.clMSSV.HeaderText = "Mã số sinh viên";
            this.clMSSV.MinimumWidth = 6;
            this.clMSSV.Name = "clMSSV";
            // 
            // clHoLot
            // 
            this.clHoLot.HeaderText = "Họ lót";
            this.clHoLot.MinimumWidth = 6;
            this.clHoLot.Name = "clHoLot";
            // 
            // clTenSV
            // 
            this.clTenSV.HeaderText = "Họ tên";
            this.clTenSV.MinimumWidth = 6;
            this.clTenSV.Name = "clTenSV";
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
            // clDiaChi
            // 
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.MinimumWidth = 6;
            this.clDiaChi.Name = "clDiaChi";
            // 
            // clLop
            // 
            this.clLop.HeaderText = "Lớp";
            this.clLop.MinimumWidth = 6;
            this.clLop.Name = "clLop";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnTimKiemSinhVien);
            this.guna2Panel1.Controls.Add(this.txtTimKiemTenSinhVien);
            this.guna2Panel1.Location = new System.Drawing.Point(22, 10);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(861, 64);
            this.guna2Panel1.TabIndex = 6;
            // 
            // btnTimKiemSinhVien
            // 
            this.btnTimKiemSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemSinhVien.BorderRadius = 8;
            this.btnTimKiemSinhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSinhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemSinhVien.Location = new System.Drawing.Point(771, 9);
            this.btnTimKiemSinhVien.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.btnTimKiemSinhVien.Name = "btnTimKiemSinhVien";
            this.btnTimKiemSinhVien.Size = new System.Drawing.Size(80, 47);
            this.btnTimKiemSinhVien.TabIndex = 1;
            this.btnTimKiemSinhVien.Text = "Tìm";
            this.btnTimKiemSinhVien.Click += new System.EventHandler(this.btnTimKiemSinhVien_Click);
            // 
            // txtTimKiemTenSinhVien
            // 
            this.txtTimKiemTenSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemTenSinhVien.BorderThickness = 0;
            this.txtTimKiemTenSinhVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemTenSinhVien.DefaultText = "";
            this.txtTimKiemTenSinhVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemTenSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemTenSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemTenSinhVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemTenSinhVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemTenSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiemTenSinhVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemTenSinhVien.Location = new System.Drawing.Point(16, 4);
            this.txtTimKiemTenSinhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemTenSinhVien.Name = "txtTimKiemTenSinhVien";
            this.txtTimKiemTenSinhVien.PasswordChar = '\0';
            this.txtTimKiemTenSinhVien.PlaceholderText = "Nhập tên sinh viên hoặc mã số sinh viên để tìm";
            this.txtTimKiemTenSinhVien.SelectedText = "";
            this.txtTimKiemTenSinhVien.Size = new System.Drawing.Size(755, 56);
            this.txtTimKiemTenSinhVien.TabIndex = 0;
            this.txtTimKiemTenSinhVien.TextChanged += new System.EventHandler(this.txtTimKiemTenSinhVien_TextChanged);
            this.txtTimKiemTenSinhVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemTenSinhVien_KeyDown);
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSinhVien.BorderRadius = 14;
            this.btnThemSinhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSinhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnThemSinhVien.Location = new System.Drawing.Point(896, 10);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(163, 64);
            this.btnThemSinhVien.TabIndex = 0;
            this.btnThemSinhVien.Text = "Thêm sinh viên";
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.pnlDsSinhVien);
            this.Controls.Add(this.pnlAddSinhVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSinhVien";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlDsSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlAddSinhVien;
        private Guna.UI2.WinForms.Guna2Panel pnlDsSinhVien;
        private Guna.UI2.WinForms.Guna2Button btnThemSinhVien;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemSinhVien;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemTenSinhVien;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLop;
    }
}