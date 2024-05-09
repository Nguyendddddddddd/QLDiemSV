namespace GUI
{
    partial class FormGiangVienXemDSLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDsLopTC = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDSLop = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDsLopTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).BeginInit();
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
            this.pnlDsLopTC.Controls.Add(this.dgvDSLop);
            this.pnlDsLopTC.Controls.Add(this.guna2HtmlLabel1);
            this.pnlDsLopTC.Controls.Add(this.cboHocKy);
            this.pnlDsLopTC.Controls.Add(this.label1);
            this.pnlDsLopTC.FillColor = System.Drawing.Color.White;
            this.pnlDsLopTC.Location = new System.Drawing.Point(16, 18);
            this.pnlDsLopTC.Margin = new System.Windows.Forms.Padding(6);
            this.pnlDsLopTC.Name = "pnlDsLopTC";
            this.pnlDsLopTC.Size = new System.Drawing.Size(1208, 819);
            this.pnlDsLopTC.TabIndex = 5;
            // 
            // dgvDSLop
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDSLop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSLop.ColumnHeadersHeight = 18;
            this.dgvDSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaLop,
            this.clNgayBD,
            this.clNgayKT,
            this.clSLSV,
            this.clSLToiDa,
            this.clTenHK,
            this.clTenMon,
            this.clTenKhoa});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSLop.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSLop.Location = new System.Drawing.Point(11, 209);
            this.dgvDSLop.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.RowHeadersVisible = false;
            this.dgvDSLop.RowHeadersWidth = 51;
            this.dgvDSLop.RowTemplate.Height = 24;
            this.dgvDSLop.Size = new System.Drawing.Size(1163, 652);
            this.dgvDSLop.TabIndex = 14;
            this.dgvDSLop.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSLop.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSLop.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSLop.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSLop.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSLop.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSLop.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSLop.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSLop.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSLop.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSLop.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSLop.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSLop.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvDSLop.ThemeStyle.ReadOnly = false;
            this.dgvDSLop.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSLop.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSLop.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSLop.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSLop.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDSLop.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSLop.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLop_CellClick);
            // 
            // clMaLop
            // 
            this.clMaLop.HeaderText = "Mã lớp";
            this.clMaLop.MinimumWidth = 8;
            this.clMaLop.Name = "clMaLop";
            // 
            // clNgayBD
            // 
            this.clNgayBD.HeaderText = "Ngày bắt đầu";
            this.clNgayBD.MinimumWidth = 8;
            this.clNgayBD.Name = "clNgayBD";
            // 
            // clNgayKT
            // 
            this.clNgayKT.HeaderText = "Ngày kết thúc";
            this.clNgayKT.MinimumWidth = 8;
            this.clNgayKT.Name = "clNgayKT";
            // 
            // clSLSV
            // 
            this.clSLSV.HeaderText = "Số lượng sinh viên";
            this.clSLSV.MinimumWidth = 8;
            this.clSLSV.Name = "clSLSV";
            // 
            // clSLToiDa
            // 
            this.clSLToiDa.HeaderText = "Số lượng tối đa";
            this.clSLToiDa.MinimumWidth = 8;
            this.clSLToiDa.Name = "clSLToiDa";
            // 
            // clTenHK
            // 
            this.clTenHK.HeaderText = "Tên học kỳ";
            this.clTenHK.MinimumWidth = 8;
            this.clTenHK.Name = "clTenHK";
            // 
            // clTenMon
            // 
            this.clTenMon.HeaderText = "Tên môn";
            this.clTenMon.MinimumWidth = 8;
            this.clTenMon.Name = "clTenMon";
            // 
            // clTenKhoa
            // 
            this.clTenKhoa.HeaderText = "Tên khoa";
            this.clTenKhoa.MinimumWidth = 8;
            this.clTenKhoa.Name = "clTenKhoa";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(353, 81);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(124, 28);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Chọn học kỳ";
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
            this.cboHocKy.Location = new System.Drawing.Point(483, 77);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(449, 36);
            this.cboHocKy.TabIndex = 10;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(5, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách lớp môn học";
            // 
            // FormGiangVienXemDSLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 854);
            this.Controls.Add(this.pnlDsLopTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiangVienXemDSLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiangVienXemDSLop";
            this.Load += new System.EventHandler(this.FormGiangVienXemDSLop_Load);
            this.pnlDsLopTC.ResumeLayout(false);
            this.pnlDsLopTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlDsLopTC;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSLSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSLToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenKhoa;
    }
}