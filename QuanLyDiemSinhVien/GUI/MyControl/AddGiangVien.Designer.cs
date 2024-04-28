namespace GUI.MyControl
{
    partial class AddGiangVien
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuuGV = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboKhoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinhGV = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMSGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoLotGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHocHam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHocVi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtChuyenMon = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 4;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(68)))), ((int)(((byte)(52)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(275, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 50);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "X";
            // 
            // btnLuuGV
            // 
            this.btnLuuGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuGV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuGV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuGV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuGV.ForeColor = System.Drawing.Color.White;
            this.btnLuuGV.Location = new System.Drawing.Point(20, 694);
            this.btnLuuGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuuGV.Name = "btnLuuGV";
            this.btnLuuGV.Size = new System.Drawing.Size(298, 56);
            this.btnLuuGV.TabIndex = 55;
            this.btnLuuGV.Text = "Lưu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(20, 617);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Mã khoa";
            // 
            // cboKhoa
            // 
            this.cboKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cboKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhoa.ItemHeight = 30;
            this.cboKhoa.Location = new System.Drawing.Point(20, 640);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(298, 36);
            this.cboKhoa.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(14, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Học hàm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Location = new System.Drawing.Point(20, 338);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(298, 58);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.BackColor = System.Drawing.Color.Transparent;
            this.rdoNu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNu.CheckedState.BorderThickness = 0;
            this.rdoNu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoNu.CheckedState.InnerOffset = -4;
            this.rdoNu.Location = new System.Drawing.Point(30, 27);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(54, 24);
            this.rdoNu.TabIndex = 8;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoNu.UncheckedState.BorderThickness = 2;
            this.rdoNu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoNu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoNu.UseVisualStyleBackColor = false;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.BackColor = System.Drawing.Color.Transparent;
            this.rdoNam.Checked = true;
            this.rdoNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNam.CheckedState.BorderThickness = 0;
            this.rdoNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoNam.CheckedState.InnerOffset = -4;
            this.rdoNam.Location = new System.Drawing.Point(163, 26);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(67, 24);
            this.rdoNam.TabIndex = 7;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoNam.UncheckedState.BorderThickness = 2;
            this.rdoNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoNam.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Họ lót";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã giảng viên";
            // 
            // dtpNgaySinhGV
            // 
            this.dtpNgaySinhGV.Checked = true;
            this.dtpNgaySinhGV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhGV.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinhGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinhGV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhGV.Location = new System.Drawing.Point(20, 283);
            this.dtpNgaySinhGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgaySinhGV.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinhGV.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinhGV.Name = "dtpNgaySinhGV";
            this.dtpNgaySinhGV.Size = new System.Drawing.Size(298, 35);
            this.dtpNgaySinhGV.TabIndex = 46;
            this.dtpNgaySinhGV.Value = new System.DateTime(2024, 4, 16, 10, 47, 30, 40);
            // 
            // txtMSGV
            // 
            this.txtMSGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMSGV.DefaultText = "";
            this.txtMSGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMSGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMSGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMSGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSGV.Location = new System.Drawing.Point(20, 81);
            this.txtMSGV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMSGV.Name = "txtMSGV";
            this.txtMSGV.PasswordChar = '\0';
            this.txtMSGV.PlaceholderText = "";
            this.txtMSGV.SelectedText = "";
            this.txtMSGV.Size = new System.Drawing.Size(298, 35);
            this.txtMSGV.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(15, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Học vị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Chuyên môn";
            // 
            // txtHoLotGV
            // 
            this.txtHoLotGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoLotGV.DefaultText = "";
            this.txtHoLotGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoLotGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoLotGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoLotGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoLotGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoLotGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoLotGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoLotGV.Location = new System.Drawing.Point(20, 147);
            this.txtHoLotGV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHoLotGV.Name = "txtHoLotGV";
            this.txtHoLotGV.PasswordChar = '\0';
            this.txtHoLotGV.PlaceholderText = "";
            this.txtHoLotGV.SelectedText = "";
            this.txtHoLotGV.Size = new System.Drawing.Size(298, 35);
            this.txtHoLotGV.TabIndex = 63;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenGV.DefaultText = "";
            this.txtTenGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenGV.Location = new System.Drawing.Point(20, 215);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.PasswordChar = '\0';
            this.txtTenGV.PlaceholderText = "";
            this.txtTenGV.SelectedText = "";
            this.txtTenGV.Size = new System.Drawing.Size(298, 35);
            this.txtTenGV.TabIndex = 64;
            // 
            // txtHocHam
            // 
            this.txtHocHam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHocHam.DefaultText = "";
            this.txtHocHam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHocHam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHocHam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHocHam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHocHam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHocHam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHocHam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHocHam.Location = new System.Drawing.Point(20, 428);
            this.txtHocHam.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHocHam.Name = "txtHocHam";
            this.txtHocHam.PasswordChar = '\0';
            this.txtHocHam.PlaceholderText = "";
            this.txtHocHam.SelectedText = "";
            this.txtHocHam.Size = new System.Drawing.Size(298, 35);
            this.txtHocHam.TabIndex = 65;
            // 
            // txtHocVi
            // 
            this.txtHocVi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHocVi.DefaultText = "";
            this.txtHocVi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHocVi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHocVi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHocVi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHocVi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHocVi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHocVi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHocVi.Location = new System.Drawing.Point(20, 497);
            this.txtHocVi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.PasswordChar = '\0';
            this.txtHocVi.PlaceholderText = "";
            this.txtHocVi.SelectedText = "";
            this.txtHocVi.Size = new System.Drawing.Size(298, 35);
            this.txtHocVi.TabIndex = 66;
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChuyenMon.DefaultText = "";
            this.txtChuyenMon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChuyenMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChuyenMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChuyenMon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChuyenMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChuyenMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChuyenMon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChuyenMon.Location = new System.Drawing.Point(20, 571);
            this.txtChuyenMon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.PasswordChar = '\0';
            this.txtChuyenMon.PlaceholderText = "";
            this.txtChuyenMon.SelectedText = "";
            this.txtChuyenMon.Size = new System.Drawing.Size(298, 35);
            this.txtChuyenMon.TabIndex = 67;
            // 
            // AddGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtChuyenMon);
            this.Controls.Add(this.txtHocVi);
            this.Controls.Add(this.txtHocHam);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.txtHoLotGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLuuGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgaySinhGV);
            this.Controls.Add(this.txtMSGV);
            this.Name = "AddGiangVien";
            this.Size = new System.Drawing.Size(333, 819);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnClose;
        public Guna.UI2.WinForms.Guna2Button btnLuuGV;
        private System.Windows.Forms.Label label8;
        public Guna.UI2.WinForms.Guna2ComboBox cboKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        public Guna.UI2.WinForms.Guna2RadioButton rdoNu;
        public Guna.UI2.WinForms.Guna2RadioButton rdoNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinhGV;
        public Guna.UI2.WinForms.Guna2TextBox txtMSGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2TextBox txtHoLotGV;
        public Guna.UI2.WinForms.Guna2TextBox txtTenGV;
        public Guna.UI2.WinForms.Guna2TextBox txtHocHam;
        public Guna.UI2.WinForms.Guna2TextBox txtHocVi;
        public Guna.UI2.WinForms.Guna2TextBox txtChuyenMon;
    }
}
