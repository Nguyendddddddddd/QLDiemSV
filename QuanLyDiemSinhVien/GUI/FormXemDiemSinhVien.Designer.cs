namespace GUI
{
    partial class FormXemDiemSinhVien
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
            this.diemSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDiemSinhVienDataSet = new GUI.Report.QLDiemSinhVienDataSet();
            this.diemSinhVienTableAdapter = new GUI.Report.QLDiemSinhVienDataSetTableAdapters.DiemSinhVienTableAdapter();
            this.flowDiem = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.diemSinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSinhVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // diemSinhVienBindingSource
            // 
            this.diemSinhVienBindingSource.DataMember = "DiemSinhVien";
            this.diemSinhVienBindingSource.DataSource = this.qLDiemSinhVienDataSet;
            // 
            // qLDiemSinhVienDataSet
            // 
            this.qLDiemSinhVienDataSet.DataSetName = "QLDiemSinhVienDataSet";
            this.qLDiemSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemSinhVienTableAdapter
            // 
            this.diemSinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // flowDiem
            // 
            this.flowDiem.AutoScroll = true;
            this.flowDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDiem.Location = new System.Drawing.Point(0, 0);
            this.flowDiem.Name = "flowDiem";
            this.flowDiem.Size = new System.Drawing.Size(1102, 683);
            this.flowDiem.TabIndex = 1;
            this.flowDiem.Paint += new System.Windows.Forms.PaintEventHandler(this.flowDiem_Paint);
            // 
            // FormXemDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 683);
            this.Controls.Add(this.flowDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormXemDiemSinhVien";
            this.Text = "FormXemDiemSinhVien";
            this.Load += new System.EventHandler(this.FormXemDiemSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diemSinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSinhVienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource diemSinhVienBindingSource;
        private Report.QLDiemSinhVienDataSet qLDiemSinhVienDataSet;
        private Report.QLDiemSinhVienDataSetTableAdapters.DiemSinhVienTableAdapter diemSinhVienTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowDiem;
    }
}