namespace GUI
{
    partial class FormBCDanhSachSinhVien
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bangDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDiemSinhVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDiemSinhVienDataSet = new GUI.Report.QLDiemSinhVienDataSet();
            this.sinhVienLopMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new GUI.Report.QLDiemSinhVienDataSetTableAdapters.SinhVienTableAdapter();
            this.sinhVienLopMonHocTableAdapter1 = new GUI.Report.QLDiemSinhVienDataSetTableAdapters.SinhVienLopMonHocTableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.cboLopHocBangDiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rpvLopMonHoc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cboLopMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cboLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvSinhVienLop = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.bangDiemTableAdapter = new GUI.Report.QLDiemSinhVienDataSetTableAdapters.BangDiemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSinhVienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienLopMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bangDiemBindingSource
            // 
            this.bangDiemBindingSource.DataMember = "BangDiem";
            this.bangDiemBindingSource.DataSource = this.qLDiemSinhVienDataSetBindingSource;
            // 
            // qLDiemSinhVienDataSetBindingSource
            // 
            this.qLDiemSinhVienDataSetBindingSource.DataSource = this.qLDiemSinhVienDataSet;
            this.qLDiemSinhVienDataSetBindingSource.Position = 0;
            // 
            // qLDiemSinhVienDataSet
            // 
            this.qLDiemSinhVienDataSet.DataSetName = "QLDiemSinhVienDataSet";
            this.qLDiemSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienLopMonHocBindingSource
            // 
            this.sinhVienLopMonHocBindingSource.DataMember = "SinhVienLopMonHoc";
            this.sinhVienLopMonHocBindingSource.DataSource = this.qLDiemSinhVienDataSetBindingSource;
            // 
            // sinhVienBindingSource1
            // 
            this.sinhVienBindingSource1.DataMember = "SinhVien";
            this.sinhVienBindingSource1.DataSource = this.qLDiemSinhVienDataSetBindingSource;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienLopMonHocTableAdapter1
            // 
            this.sinhVienLopMonHocTableAdapter1.ClearBeforeFill = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.guna2Panel3);
            this.tabPage3.Controls.Add(this.reportViewer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1094, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bảng điểm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.Controls.Add(this.cboLopHocBangDiem);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1088, 100);
            this.guna2Panel3.TabIndex = 8;
            // 
            // cboLopHocBangDiem
            // 
            this.cboLopHocBangDiem.BackColor = System.Drawing.Color.Transparent;
            this.cboLopHocBangDiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopHocBangDiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHocBangDiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopHocBangDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopHocBangDiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopHocBangDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopHocBangDiem.ItemHeight = 30;
            this.cboLopHocBangDiem.Location = new System.Drawing.Point(5, 42);
            this.cboLopHocBangDiem.Name = "cboLopHocBangDiem";
            this.cboLopHocBangDiem.Size = new System.Drawing.Size(246, 36);
            this.cboLopHocBangDiem.TabIndex = 7;
            this.cboLopHocBangDiem.SelectedIndexChanged += new System.EventHandler(this.cboLopHocBangDiem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lọc theo lớp môn học";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bangDiemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report.BangDiemMonHoc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1088, 523);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rpvLopMonHoc);
            this.tabPage2.Controls.Add(this.guna2Panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1094, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lớp môn học";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rpvLopMonHoc
            // 
            this.rpvLopMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "QLDiemSV";
            reportDataSource2.Value = this.sinhVienLopMonHocBindingSource;
            this.rpvLopMonHoc.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvLopMonHoc.LocalReport.ReportEmbeddedResource = "GUI.Report.BCDanhSachSinhVien.rdlc";
            this.rpvLopMonHoc.Location = new System.Drawing.Point(3, 103);
            this.rpvLopMonHoc.Name = "rpvLopMonHoc";
            this.rpvLopMonHoc.ServerReport.BearerToken = null;
            this.rpvLopMonHoc.Size = new System.Drawing.Size(1088, 529);
            this.rpvLopMonHoc.TabIndex = 7;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.Controls.Add(this.cboLopMonHoc);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1088, 100);
            this.guna2Panel2.TabIndex = 6;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // cboLopMonHoc
            // 
            this.cboLopMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboLopMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopMonHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopMonHoc.ItemHeight = 30;
            this.cboLopMonHoc.Location = new System.Drawing.Point(5, 42);
            this.cboLopMonHoc.Name = "cboLopMonHoc";
            this.cboLopMonHoc.Size = new System.Drawing.Size(246, 36);
            this.cboLopMonHoc.TabIndex = 5;
            this.cboLopMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboLopMonHoc_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lọc theo lớp môn học";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guna2Panel1);
            this.tabPage1.Controls.Add(this.rpvSinhVienLop);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1094, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lớp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Controls.Add(this.cboLop);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1088, 100);
            this.guna2Panel1.TabIndex = 3;
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
            this.cboLop.Location = new System.Drawing.Point(5, 42);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(246, 36);
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lọc theo lớp";
            // 
            // rpvSinhVienLop
            // 
            this.rpvSinhVienLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "QLDiemSV";
            reportDataSource3.Value = this.sinhVienBindingSource1;
            this.rpvSinhVienLop.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvSinhVienLop.LocalReport.ReportEmbeddedResource = "GUI.Report.BCDanhSachSinhVien.rdlc";
            this.rpvSinhVienLop.Location = new System.Drawing.Point(-4, 109);
            this.rpvSinhVienLop.Name = "rpvSinhVienLop";
            this.rpvSinhVienLop.ServerReport.BearerToken = null;
            this.rpvSinhVienLop.Size = new System.Drawing.Size(1102, 530);
            this.rpvSinhVienLop.TabIndex = 2;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1102, 683);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 2;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // bangDiemTableAdapter
            // 
            this.bangDiemTableAdapter.ClearBeforeFill = true;
            // 
            // FormBCDanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBCDanhSachSinhVien";
            this.Text = "FormBCDanhSachSinhVien";
            this.Load += new System.EventHandler(this.FormBCDanhSachSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSinhVienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienLopMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Report.QLDiemSinhVienDataSet qLDiemSinhVienDataSet;
        private System.Windows.Forms.BindingSource qLDiemSinhVienDataSetBindingSource;
        private Report.QLDiemSinhVienDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private Report.QLDiemSinhVienDataSetTableAdapters.SinhVienLopMonHocTableAdapter sinhVienLopMonHocTableAdapter1;
        private System.Windows.Forms.BindingSource sinhVienLopMonHocBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvLopMonHoc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cboLop;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvSinhVienLop;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopHocBangDiem;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.BindingSource sinhVienBindingSource1;
        private System.Windows.Forms.BindingSource bangDiemBindingSource;
        private Report.QLDiemSinhVienDataSetTableAdapters.BangDiemTableAdapter bangDiemTableAdapter;
    }
}