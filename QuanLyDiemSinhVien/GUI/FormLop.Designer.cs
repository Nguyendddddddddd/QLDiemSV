namespace GUI
{
    partial class FormLop
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
            this.pnlDsLop = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvLop = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuongSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiemLop = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemLop = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAddLop = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDsLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDsLop
            // 
            this.pnlDsLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDsLop.BackColor = System.Drawing.Color.Transparent;
            this.pnlDsLop.BorderColor = System.Drawing.Color.DimGray;
            this.pnlDsLop.BorderRadius = 14;
            this.pnlDsLop.BorderThickness = 1;
            this.pnlDsLop.Controls.Add(this.dgvLop);
            this.pnlDsLop.Controls.Add(this.guna2Panel1);
            this.pnlDsLop.Controls.Add(this.btnThemLop);
            this.pnlDsLop.FillColor = System.Drawing.Color.White;
            this.pnlDsLop.Location = new System.Drawing.Point(14, 14);
            this.pnlDsLop.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDsLop.Name = "pnlDsLop";
            this.pnlDsLop.Size = new System.Drawing.Size(1074, 655);
            this.pnlDsLop.TabIndex = 4;
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLop.ColumnHeadersHeight = 18;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaLop,
            this.clNganh,
            this.clGiangVien,
            this.clSoLuongSV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLop.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLop.Location = new System.Drawing.Point(19, 87);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(1037, 543);
            this.dgvLop.TabIndex = 8;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLop.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLop.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLop.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLop.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLop.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLop.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLop.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLop.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvLop.ThemeStyle.ReadOnly = false;
            this.dgvLop.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLop.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLop.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLop.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLop.ThemeStyle.RowsStyle.Height = 24;
            this.dgvLop.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLop.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // clMaLop
            // 
            this.clMaLop.HeaderText = "Mã lớp";
            this.clMaLop.MinimumWidth = 6;
            this.clMaLop.Name = "clMaLop";
            // 
            // clNganh
            // 
            this.clNganh.HeaderText = "Ngành";
            this.clNganh.MinimumWidth = 6;
            this.clNganh.Name = "clNganh";
            // 
            // clGiangVien
            // 
            this.clGiangVien.HeaderText = "Cố vấn học tập";
            this.clGiangVien.MinimumWidth = 6;
            this.clGiangVien.Name = "clGiangVien";
            // 
            // clSoLuongSV
            // 
            this.clSoLuongSV.HeaderText = "Số lượng sinh viên";
            this.clSoLuongSV.MinimumWidth = 6;
            this.clSoLuongSV.Name = "clSoLuongSV";
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
            this.guna2Panel1.Location = new System.Drawing.Point(22, 10);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(861, 64);
            this.guna2Panel1.TabIndex = 6;
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
            this.btnTimKiemLop.Location = new System.Drawing.Point(771, 9);
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
            this.txtTimKiemLop.PlaceholderText = "Nhập mã lớp để tìm";
            this.txtTimKiemLop.SelectedText = "";
            this.txtTimKiemLop.Size = new System.Drawing.Size(755, 56);
            this.txtTimKiemLop.TabIndex = 0;
            this.txtTimKiemLop.TextChanged += new System.EventHandler(this.txtTimKiemLop_TextChanged);
            this.txtTimKiemLop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemLop_KeyDown);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLop.BorderRadius = 14;
            this.btnThemLop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemLop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(896, 10);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(163, 64);
            this.btnThemLop.TabIndex = 0;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // pnlAddLop
            // 
            this.pnlAddLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddLop.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddLop.BorderColor = System.Drawing.Color.DimGray;
            this.pnlAddLop.BorderRadius = 14;
            this.pnlAddLop.BorderThickness = 1;
            this.pnlAddLop.FillColor = System.Drawing.Color.White;
            this.pnlAddLop.Location = new System.Drawing.Point(792, 14);
            this.pnlAddLop.Margin = new System.Windows.Forms.Padding(5);
            this.pnlAddLop.Name = "pnlAddLop";
            this.pnlAddLop.Size = new System.Drawing.Size(296, 655);
            this.pnlAddLop.TabIndex = 3;
            this.pnlAddLop.Visible = false;
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.pnlDsLop);
            this.Controls.Add(this.pnlAddLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLop";
            this.Text = "FormLop";
            this.Load += new System.EventHandler(this.FormLop_Load);
            this.pnlDsLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlDsLop;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemLop;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemLop;
        private Guna.UI2.WinForms.Guna2Button btnThemLop;
        private Guna.UI2.WinForms.Guna2Panel pnlAddLop;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuongSV;
    }
}