namespace GUI
{
    partial class FormDiemHocKy
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
            this.dgvDiemHK = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiemHe4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhatDiemHK = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiemSV = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHK)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiemHK
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDiemHK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiemHK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiemHK.ColumnHeadersHeight = 18;
            this.dgvDiemHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDiemHK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMSSV,
            this.clTenSinhVien,
            this.clHK,
            this.clNamHoc,
            this.clDiem,
            this.clDiemHe4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiemHK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiemHK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemHK.Location = new System.Drawing.Point(12, 205);
            this.dgvDiemHK.Name = "dgvDiemHK";
            this.dgvDiemHK.RowHeadersVisible = false;
            this.dgvDiemHK.RowHeadersWidth = 51;
            this.dgvDiemHK.RowTemplate.Height = 24;
            this.dgvDiemHK.Size = new System.Drawing.Size(1078, 466);
            this.dgvDiemHK.TabIndex = 0;
            this.dgvDiemHK.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemHK.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDiemHK.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDiemHK.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDiemHK.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDiemHK.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemHK.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemHK.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDiemHK.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiemHK.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemHK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiemHK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDiemHK.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvDiemHK.ThemeStyle.ReadOnly = false;
            this.dgvDiemHK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemHK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiemHK.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemHK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDiemHK.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDiemHK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemHK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clMSSV
            // 
            this.clMSSV.HeaderText = "Mã số sinh viên";
            this.clMSSV.MinimumWidth = 6;
            this.clMSSV.Name = "clMSSV";
            // 
            // clTenSinhVien
            // 
            this.clTenSinhVien.HeaderText = "Tên sinh viên";
            this.clTenSinhVien.MinimumWidth = 6;
            this.clTenSinhVien.Name = "clTenSinhVien";
            // 
            // clHK
            // 
            this.clHK.HeaderText = "Học kỳ";
            this.clHK.MinimumWidth = 6;
            this.clHK.Name = "clHK";
            // 
            // clNamHoc
            // 
            this.clNamHoc.HeaderText = "Năm học";
            this.clNamHoc.MinimumWidth = 6;
            this.clNamHoc.Name = "clNamHoc";
            // 
            // clDiem
            // 
            this.clDiem.HeaderText = "Điểm hệ 10";
            this.clDiem.MinimumWidth = 6;
            this.clDiem.Name = "clDiem";
            // 
            // clDiemHe4
            // 
            this.clDiemHe4.HeaderText = "Điểm hệ 4";
            this.clDiemHe4.MinimumWidth = 6;
            this.clDiemHe4.Name = "clDiemHe4";
            // 
            // btnCapNhatDiemHK
            // 
            this.btnCapNhatDiemHK.BorderRadius = 10;
            this.btnCapNhatDiemHK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatDiemHK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatDiemHK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhatDiemHK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhatDiemHK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapNhatDiemHK.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatDiemHK.Location = new System.Drawing.Point(910, 34);
            this.btnCapNhatDiemHK.Name = "btnCapNhatDiemHK";
            this.btnCapNhatDiemHK.Size = new System.Drawing.Size(180, 45);
            this.btnCapNhatDiemHK.TabIndex = 1;
            this.btnCapNhatDiemHK.Text = "Cập nhật điểm học kỳ";
            this.btnCapNhatDiemHK.Click += new System.EventHandler(this.btnCapNhatDiemHK_Click);
            // 
            // btnTimKiemSV
            // 
            this.btnTimKiemSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemSV.BorderRadius = 8;
            this.btnTimKiemSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSV.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemSV.Location = new System.Drawing.Point(795, 9);
            this.btnTimKiemSV.Margin = new System.Windows.Forms.Padding(10);
            this.btnTimKiemSV.Name = "btnTimKiemSV";
            this.btnTimKiemSV.Size = new System.Drawing.Size(80, 47);
            this.btnTimKiemSV.TabIndex = 1;
            this.btnTimKiemSV.Text = "Tìm";
            this.btnTimKiemSV.Click += new System.EventHandler(this.btnTimKiemSV_Click);
            // 
            // txtTimSV
            // 
            this.txtTimSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimSV.BorderThickness = 0;
            this.txtTimSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimSV.DefaultText = "";
            this.txtTimSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimSV.Location = new System.Drawing.Point(16, 4);
            this.txtTimSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimSV.Name = "txtTimSV";
            this.txtTimSV.PasswordChar = '\0';
            this.txtTimSV.PlaceholderText = "Nhập để tìm";
            this.txtTimSV.SelectedText = "";
            this.txtTimSV.Size = new System.Drawing.Size(774, 56);
            this.txtTimSV.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnTimKiemSV);
            this.guna2Panel1.Controls.Add(this.txtTimSV);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 23);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(885, 64);
            this.guna2Panel1.TabIndex = 14;
            // 
            // cboHocKy
            // 
            this.cboHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cboHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHocKy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(12, 163);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(531, 36);
            this.cboHocKy.TabIndex = 15;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lớp";
            // 
            // cboLop
            // 
            this.cboLop.BackColor = System.Drawing.Color.Transparent;
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLop.ItemHeight = 30;
            this.cboLop.Location = new System.Drawing.Point(549, 163);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(163, 36);
            this.cboLop.TabIndex = 17;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lọc theo";
            // 
            // FormDiemHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnCapNhatDiemHK);
            this.Controls.Add(this.dgvDiemHK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiemHocKy";
            this.Text = "FormDiemHocKy";
            this.Load += new System.EventHandler(this.FormDiemHocKy_Load);
            this.VisibleChanged += new System.EventHandler(this.FormDiemHocKy_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHK)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvDiemHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiemHe4;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatDiemHK;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemSV;
        private Guna.UI2.WinForms.Guna2TextBox txtTimSV;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboLop;
        private System.Windows.Forms.Label label4;
    }
}