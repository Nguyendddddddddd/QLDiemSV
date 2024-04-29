namespace GUI
{
    partial class FormHocKy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDsSinhVien = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.cboNamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvHocKy = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMaHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiemHocKy = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemHocKy = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlAddSinhVien = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDsSinhVien.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDsSinhVien
            // 
            this.pnlDsSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDsSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.pnlDsSinhVien.BorderColor = System.Drawing.Color.DimGray;
            this.pnlDsSinhVien.BorderRadius = 14;
            this.pnlDsSinhVien.BorderThickness = 1;
            this.pnlDsSinhVien.Controls.Add(this.guna2Panel2);
            this.pnlDsSinhVien.Controls.Add(this.dgvHocKy);
            this.pnlDsSinhVien.Controls.Add(this.guna2Panel1);
            this.pnlDsSinhVien.FillColor = System.Drawing.Color.White;
            this.pnlDsSinhVien.Location = new System.Drawing.Point(14, 14);
            this.pnlDsSinhVien.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDsSinhVien.Name = "pnlDsSinhVien";
            this.pnlDsSinhVien.Size = new System.Drawing.Size(1074, 655);
            this.pnlDsSinhVien.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.btnXoa);
            this.guna2Panel2.Controls.Add(this.btnThem);
            this.guna2Panel2.Controls.Add(this.cboNamHoc);
            this.guna2Panel2.Controls.Add(this.cboKy);
            this.guna2Panel2.Location = new System.Drawing.Point(16, 87);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(402, 535);
            this.guna2Panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm học";
            // 
            // btnXoa
            // 
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(212, 173);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 48);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(90, 173);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 48);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNamHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNamHoc.ItemHeight = 30;
            this.cboNamHoc.Location = new System.Drawing.Point(90, 93);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(222, 36);
            this.cboNamHoc.TabIndex = 1;
            // 
            // cboKy
            // 
            this.cboKy.BackColor = System.Drawing.Color.Transparent;
            this.cboKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKy.ItemHeight = 30;
            this.cboKy.Items.AddRange(new object[] {
            "Học kỳ I",
            "Học kỳ II",
            "Học Kỳ III (Học kỳ hè)"});
            this.cboKy.Location = new System.Drawing.Point(90, 35);
            this.cboKy.Name = "cboKy";
            this.cboKy.Size = new System.Drawing.Size(222, 36);
            this.cboKy.StartIndex = 0;
            this.cboKy.TabIndex = 0;
            // 
            // dgvHocKy
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvHocKy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHocKy.ColumnHeadersHeight = 18;
            this.dgvHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHocKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaHK,
            this.clTenHocKy,
            this.clNamHoc});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocKy.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHocKy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocKy.Location = new System.Drawing.Point(444, 87);
            this.dgvHocKy.Name = "dgvHocKy";
            this.dgvHocKy.RowHeadersVisible = false;
            this.dgvHocKy.RowHeadersWidth = 51;
            this.dgvHocKy.RowTemplate.Height = 24;
            this.dgvHocKy.Size = new System.Drawing.Size(614, 535);
            this.dgvHocKy.TabIndex = 7;
            this.dgvHocKy.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocKy.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHocKy.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHocKy.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHocKy.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHocKy.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocKy.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocKy.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHocKy.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHocKy.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHocKy.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHocKy.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHocKy.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvHocKy.ThemeStyle.ReadOnly = false;
            this.dgvHocKy.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocKy.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHocKy.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHocKy.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHocKy.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHocKy.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocKy.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHocKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocKy_CellClick);
            // 
            // clMaHK
            // 
            this.clMaHK.HeaderText = "Mã học kỳ";
            this.clMaHK.MinimumWidth = 6;
            this.clMaHK.Name = "clMaHK";
            // 
            // clTenHocKy
            // 
            this.clTenHocKy.HeaderText = "Tên học kỳ";
            this.clTenHocKy.MinimumWidth = 6;
            this.clTenHocKy.Name = "clTenHocKy";
            // 
            // clNamHoc
            // 
            this.clNamHoc.HeaderText = "Năm học";
            this.clNamHoc.MinimumWidth = 6;
            this.clNamHoc.Name = "clNamHoc";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnTimKiemHocKy);
            this.guna2Panel1.Controls.Add(this.txtTimKiemHocKy);
            this.guna2Panel1.Location = new System.Drawing.Point(16, 10);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1042, 64);
            this.guna2Panel1.TabIndex = 6;
            // 
            // btnTimKiemHocKy
            // 
            this.btnTimKiemHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemHocKy.BorderRadius = 8;
            this.btnTimKiemHocKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemHocKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemHocKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemHocKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemHocKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemHocKy.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemHocKy.Location = new System.Drawing.Point(952, 9);
            this.btnTimKiemHocKy.Margin = new System.Windows.Forms.Padding(10);
            this.btnTimKiemHocKy.Name = "btnTimKiemHocKy";
            this.btnTimKiemHocKy.Size = new System.Drawing.Size(80, 47);
            this.btnTimKiemHocKy.TabIndex = 1;
            this.btnTimKiemHocKy.Text = "Tìm";
            // 
            // txtTimKiemHocKy
            // 
            this.txtTimKiemHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemHocKy.BorderThickness = 0;
            this.txtTimKiemHocKy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemHocKy.DefaultText = "";
            this.txtTimKiemHocKy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemHocKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemHocKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemHocKy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemHocKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemHocKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiemHocKy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemHocKy.Location = new System.Drawing.Point(16, 4);
            this.txtTimKiemHocKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemHocKy.Name = "txtTimKiemHocKy";
            this.txtTimKiemHocKy.PasswordChar = '\0';
            this.txtTimKiemHocKy.PlaceholderText = "Nhập tên sinh viên hoặc mã số sinh viên để tìm";
            this.txtTimKiemHocKy.SelectedText = "";
            this.txtTimKiemHocKy.Size = new System.Drawing.Size(936, 56);
            this.txtTimKiemHocKy.TabIndex = 0;
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
            this.pnlAddSinhVien.Margin = new System.Windows.Forms.Padding(5);
            this.pnlAddSinhVien.Name = "pnlAddSinhVien";
            this.pnlAddSinhVien.Size = new System.Drawing.Size(296, 655);
            this.pnlAddSinhVien.TabIndex = 3;
            this.pnlAddSinhVien.Visible = false;
            // 
            // FormHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.pnlDsSinhVien);
            this.Controls.Add(this.pnlAddSinhVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHocKy";
            this.Text = "FormHocKy";
            this.Load += new System.EventHandler(this.FormHocKy_Load);
            this.pnlDsSinhVien.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlDsSinhVien;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHocKy;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemHocKy;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemHocKy;
        private Guna.UI2.WinForms.Guna2Panel pnlAddSinhVien;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cboKy;
        private Guna.UI2.WinForms.Guna2ComboBox cboNamHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamHoc;
    }
}