namespace GUI.MyControl
{
    partial class KhoaContainer
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
            this.lbTenKhoa = new System.Windows.Forms.Label();
            this.lbSoLuongNganh = new System.Windows.Forms.Label();
            this.lbSoLuongGV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTenKhoa
            // 
            this.lbTenKhoa.AutoSize = true;
            this.lbTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhoa.Location = new System.Drawing.Point(10, 10);
            this.lbTenKhoa.Margin = new System.Windows.Forms.Padding(10);
            this.lbTenKhoa.Name = "lbTenKhoa";
            this.lbTenKhoa.Size = new System.Drawing.Size(88, 20);
            this.lbTenKhoa.TabIndex = 0;
            this.lbTenKhoa.Text = "Tên Khoa";
            // 
            // lbSoLuongNganh
            // 
            this.lbSoLuongNganh.AutoSize = true;
            this.lbSoLuongNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongNganh.Location = new System.Drawing.Point(10, 70);
            this.lbSoLuongNganh.Margin = new System.Windows.Forms.Padding(10);
            this.lbSoLuongNganh.Name = "lbSoLuongNganh";
            this.lbSoLuongNganh.Size = new System.Drawing.Size(114, 16);
            this.lbSoLuongNganh.TabIndex = 1;
            this.lbSoLuongNganh.Text = "Số lượng ngành";
            // 
            // lbSoLuongGV
            // 
            this.lbSoLuongGV.AutoSize = true;
            this.lbSoLuongGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongGV.Location = new System.Drawing.Point(10, 94);
            this.lbSoLuongGV.Margin = new System.Windows.Forms.Padding(10);
            this.lbSoLuongGV.Name = "lbSoLuongGV";
            this.lbSoLuongGV.Size = new System.Drawing.Size(144, 16);
            this.lbSoLuongGV.TabIndex = 2;
            this.lbSoLuongGV.Text = "Số lượng giảng viên";
            // 
            // KhoaContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSoLuongGV);
            this.Controls.Add(this.lbSoLuongNganh);
            this.Controls.Add(this.lbTenKhoa);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "KhoaContainer";
            this.Size = new System.Drawing.Size(248, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenKhoa;
        private System.Windows.Forms.Label lbSoLuongNganh;
        private System.Windows.Forms.Label lbSoLuongGV;
    }
}
