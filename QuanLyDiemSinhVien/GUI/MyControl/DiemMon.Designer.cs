namespace GUI.MyControl
{
    partial class DiemMon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbXepLoai = new System.Windows.Forms.Label();
            this.lbDTBhe4 = new System.Windows.Forms.Label();
            this.lbDiemTBHK = new System.Windows.Forms.Label();
            this.dgvDiemMH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiemChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbHK = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemMH)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lbXepLoai);
            this.guna2Panel1.Controls.Add(this.lbDTBhe4);
            this.guna2Panel1.Controls.Add(this.lbDiemTBHK);
            this.guna2Panel1.Controls.Add(this.dgvDiemMH);
            this.guna2Panel1.Controls.Add(this.lbHK);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1102, 258);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lbXepLoai
            // 
            this.lbXepLoai.AutoSize = true;
            this.lbXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXepLoai.Location = new System.Drawing.Point(8, 232);
            this.lbXepLoai.Margin = new System.Windows.Forms.Padding(3);
            this.lbXepLoai.Name = "lbXepLoai";
            this.lbXepLoai.Size = new System.Drawing.Size(211, 16);
            this.lbXepLoai.TabIndex = 9;
            this.lbXepLoai.Text = "Phân loại điểm trung bình giỏi";
            // 
            // lbDTBhe4
            // 
            this.lbDTBhe4.AutoSize = true;
            this.lbDTBhe4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDTBhe4.Location = new System.Drawing.Point(8, 210);
            this.lbDTBhe4.Margin = new System.Windows.Forms.Padding(3);
            this.lbDTBhe4.Name = "lbDTBhe4";
            this.lbDTBhe4.Size = new System.Drawing.Size(195, 16);
            this.lbDTBhe4.TabIndex = 8;
            this.lbDTBhe4.Text = "Điểm trung bình học kỳ hệ 4";
            // 
            // lbDiemTBHK
            // 
            this.lbDiemTBHK.AutoSize = true;
            this.lbDiemTBHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemTBHK.Location = new System.Drawing.Point(8, 188);
            this.lbDiemTBHK.Margin = new System.Windows.Forms.Padding(3);
            this.lbDiemTBHK.Name = "lbDiemTBHK";
            this.lbDiemTBHK.Size = new System.Drawing.Size(203, 16);
            this.lbDiemTBHK.TabIndex = 7;
            this.lbDiemTBHK.Text = "Điểm trung bình học kỳ hệ 10";
            // 
            // dgvDiemMH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDiemMH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiemMH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiemMH.ColumnHeadersHeight = 18;
            this.dgvDiemMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDiemMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaMon,
            this.clTenMon,
            this.clDiem,
            this.clDiemChu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiemMH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiemMH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemMH.Location = new System.Drawing.Point(5, 32);
            this.dgvDiemMH.Name = "dgvDiemMH";
            this.dgvDiemMH.RowHeadersVisible = false;
            this.dgvDiemMH.RowHeadersWidth = 51;
            this.dgvDiemMH.RowTemplate.Height = 24;
            this.dgvDiemMH.Size = new System.Drawing.Size(1093, 150);
            this.dgvDiemMH.TabIndex = 6;
            this.dgvDiemMH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemMH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDiemMH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDiemMH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDiemMH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDiemMH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemMH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemMH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDiemMH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiemMH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemMH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiemMH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDiemMH.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvDiemMH.ThemeStyle.ReadOnly = false;
            this.dgvDiemMH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemMH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiemMH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemMH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDiemMH.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDiemMH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemMH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // clDiem
            // 
            this.clDiem.HeaderText = "Điểm";
            this.clDiem.MinimumWidth = 6;
            this.clDiem.Name = "clDiem";
            // 
            // clDiemChu
            // 
            this.clDiemChu.HeaderText = "Điểm chữ";
            this.clDiemChu.MinimumWidth = 6;
            this.clDiemChu.Name = "clDiemChu";
            // 
            // lbHK
            // 
            this.lbHK.AutoSize = true;
            this.lbHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHK.Location = new System.Drawing.Point(8, 10);
            this.lbHK.Margin = new System.Windows.Forms.Padding(3);
            this.lbHK.Name = "lbHK";
            this.lbHK.Size = new System.Drawing.Size(55, 16);
            this.lbHK.TabIndex = 5;
            this.lbHK.Text = "Học kỳ";
            // 
            // DiemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DiemMon";
            this.Size = new System.Drawing.Size(1102, 258);
            this.Load += new System.EventHandler(this.DiemMon_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbXepLoai;
        private System.Windows.Forms.Label lbDTBhe4;
        private System.Windows.Forms.Label lbDiemTBHK;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiemMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiemChu;
        private System.Windows.Forms.Label lbHK;
    }
}
