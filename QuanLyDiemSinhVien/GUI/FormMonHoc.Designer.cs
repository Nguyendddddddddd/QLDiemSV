namespace GUI
{
    partial class FormMonHoc
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
            this.pnlDsMonHoc = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvMonHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiemMonHoc = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemMonHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemMonHoc = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAddMonHoc = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDsMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDsMonHoc
            // 
            this.pnlDsMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDsMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.pnlDsMonHoc.BorderColor = System.Drawing.Color.DimGray;
            this.pnlDsMonHoc.BorderRadius = 14;
            this.pnlDsMonHoc.BorderThickness = 1;
            this.pnlDsMonHoc.Controls.Add(this.dgvMonHoc);
            this.pnlDsMonHoc.Controls.Add(this.guna2Panel1);
            this.pnlDsMonHoc.Controls.Add(this.btnThemMonHoc);
            this.pnlDsMonHoc.FillColor = System.Drawing.Color.White;
            this.pnlDsMonHoc.Location = new System.Drawing.Point(14, 14);
            this.pnlDsMonHoc.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDsMonHoc.Name = "pnlDsMonHoc";
            this.pnlDsMonHoc.Size = new System.Drawing.Size(1074, 655);
            this.pnlDsMonHoc.TabIndex = 6;
            // 
            // dgvMonHoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonHoc.ColumnHeadersHeight = 18;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaMon,
            this.clTenMon,
            this.clSoTinChi,
            this.clMoTa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.Location = new System.Drawing.Point(19, 87);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.Size = new System.Drawing.Size(1037, 543);
            this.dgvMonHoc.TabIndex = 8;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvMonHoc.ThemeStyle.ReadOnly = false;
            this.dgvMonHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMonHoc.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMonHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            // 
            // clMaMon
            // 
            this.clMaMon.HeaderText = "Mã môn";
            this.clMaMon.MinimumWidth = 6;
            this.clMaMon.Name = "clMaMon";
            // 
            // clTenMon
            // 
            this.clTenMon.HeaderText = "Tên môn";
            this.clTenMon.MinimumWidth = 6;
            this.clTenMon.Name = "clTenMon";
            // 
            // clSoTinChi
            // 
            this.clSoTinChi.HeaderText = "Số tín chỉ";
            this.clSoTinChi.MinimumWidth = 6;
            this.clSoTinChi.Name = "clSoTinChi";
            // 
            // clMoTa
            // 
            this.clMoTa.HeaderText = "Mô tả";
            this.clMoTa.MinimumWidth = 6;
            this.clMoTa.Name = "clMoTa";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnTimKiemMonHoc);
            this.guna2Panel1.Controls.Add(this.txtTimKiemMonHoc);
            this.guna2Panel1.Location = new System.Drawing.Point(22, 10);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(861, 64);
            this.guna2Panel1.TabIndex = 6;
            // 
            // btnTimKiemMonHoc
            // 
            this.btnTimKiemMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemMonHoc.BorderRadius = 8;
            this.btnTimKiemMonHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemMonHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemMonHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemMonHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemMonHoc.Location = new System.Drawing.Point(771, 9);
            this.btnTimKiemMonHoc.Margin = new System.Windows.Forms.Padding(10);
            this.btnTimKiemMonHoc.Name = "btnTimKiemMonHoc";
            this.btnTimKiemMonHoc.Size = new System.Drawing.Size(80, 47);
            this.btnTimKiemMonHoc.TabIndex = 1;
            this.btnTimKiemMonHoc.Text = "Tìm";
            this.btnTimKiemMonHoc.Click += new System.EventHandler(this.btnTimKiemMonHoc_Click);
            // 
            // txtTimKiemMonHoc
            // 
            this.txtTimKiemMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemMonHoc.BorderThickness = 0;
            this.txtTimKiemMonHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemMonHoc.DefaultText = "";
            this.txtTimKiemMonHoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemMonHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemMonHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemMonHoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiemMonHoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemMonHoc.Location = new System.Drawing.Point(16, 4);
            this.txtTimKiemMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemMonHoc.Name = "txtTimKiemMonHoc";
            this.txtTimKiemMonHoc.PasswordChar = '\0';
            this.txtTimKiemMonHoc.PlaceholderText = "Nhập tên môn học hoặc mã môn học để tìm";
            this.txtTimKiemMonHoc.SelectedText = "";
            this.txtTimKiemMonHoc.Size = new System.Drawing.Size(755, 56);
            this.txtTimKiemMonHoc.TabIndex = 0;
            this.txtTimKiemMonHoc.TextChanged += new System.EventHandler(this.txtTimKiemMonHoc_TextChanged);
            this.txtTimKiemMonHoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemMonHoc_KeyDown);
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMonHoc.BorderRadius = 14;
            this.btnThemMonHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMonHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMonHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMonHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnThemMonHoc.Location = new System.Drawing.Point(896, 10);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(163, 64);
            this.btnThemMonHoc.TabIndex = 0;
            this.btnThemMonHoc.Text = "Thêm môn học";
            this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
            // 
            // pnlAddMonHoc
            // 
            this.pnlAddMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddMonHoc.BorderColor = System.Drawing.Color.DimGray;
            this.pnlAddMonHoc.BorderRadius = 14;
            this.pnlAddMonHoc.BorderThickness = 1;
            this.pnlAddMonHoc.FillColor = System.Drawing.Color.White;
            this.pnlAddMonHoc.Location = new System.Drawing.Point(792, 14);
            this.pnlAddMonHoc.Margin = new System.Windows.Forms.Padding(5);
            this.pnlAddMonHoc.Name = "pnlAddMonHoc";
            this.pnlAddMonHoc.Size = new System.Drawing.Size(296, 655);
            this.pnlAddMonHoc.TabIndex = 5;
            this.pnlAddMonHoc.Visible = false;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.pnlDsMonHoc);
            this.Controls.Add(this.pnlAddMonHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMonHoc";
            this.Text = "FormMonHoc";
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            this.pnlDsMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlDsMonHoc;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMonHoc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemMonHoc;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemMonHoc;
        private Guna.UI2.WinForms.Guna2Button btnThemMonHoc;
        private Guna.UI2.WinForms.Guna2Panel pnlAddMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMoTa;
    }
}