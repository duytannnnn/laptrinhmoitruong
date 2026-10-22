namespace Lab04
{
    partial class FormChinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            grpThongTin = new GroupBox();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnThemKhoa = new Button();
            comboBox1 = new ComboBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            txtDiemTB = new TextBox();
            txtMaSV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvSinhVien = new DataGridView();
            lblTrangthai = new Label();
            lblTongso = new Label();
            menuStrip1.SuspendLayout();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(52, 24);
            tệpToolStripMenuItem.Text = "Tệp ";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(75, 24);
            toolStripMenuItem1.Text = " Dữ liệu";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(982, 61);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(btnThemKhoa);
            grpThongTin.Controls.Add(comboBox1);
            grpThongTin.Controls.Add(rdoNu);
            grpThongTin.Controls.Add(rdoNam);
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(txtDiemTB);
            grpThongTin.Controls.Add(txtMaSV);
            grpThongTin.Controls.Add(label7);
            grpThongTin.Controls.Add(label6);
            grpThongTin.Controls.Add(label5);
            grpThongTin.Controls.Add(label4);
            grpThongTin.Controls.Add(label3);
            grpThongTin.Controls.Add(label2);
            grpThongTin.Location = new Point(0, 94);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(290, 480);
            grpThongTin.TabIndex = 2;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông Tin Sinh Viên";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Location = new Point(168, 401);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "✕ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(167, 436);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "↻ Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ActiveCaption;
            btnSua.Location = new Point(36, 436);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 16;
            btnSua.Text = "✎ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SpringGreen;
            btnThem.Location = new Point(36, 401);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 15;
            btnThem.Text = "✚ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnThemKhoa
            // 
            btnThemKhoa.BackColor = Color.Yellow;
            btnThemKhoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemKhoa.Location = new Point(228, 283);
            btnThemKhoa.Name = "btnThemKhoa";
            btnThemKhoa.Size = new Size(63, 41);
            btnThemKhoa.TabIndex = 3;
            btnThemKhoa.Text = "+";
            btnThemKhoa.UseVisualStyleBackColor = false;
            btnThemKhoa.Click += btnThemKhoa_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Công nghệ thông tin", "Hệ thống thông tin quản lý", "Kiến trúc - Mỹ thuật", "Xây dựng", "Quản trị kinh doanh", "Marketing - Kinh doanh quốc tế", "Tài chính - Thương mại", "Quản trị Du lịch - Nhà hàng - Khách sạn", "Luật", "Dược", "Y", "Điều dưỡng - Kỹ thuật y học", "Thú y", "Thẩm mỹ và Khoa học sự sống", "Tiếng Anh", "Nhật Bản học", "Trung Quốc học", "Hàn Quốc học", "Khoa học Xã hội và Quan hệ Công chúng", "Truyền thông và Thiết kế", "Viện Kỹ thuật HUTECH", "Viện Khoa học Ứng dụng HUTECH", "Viện Khoa học Sức khỏe HUTECH", "Viện Đào tạo Quốc tế HUTECH", "Viện Công nghệ Việt - Nhật (VJIT)", "Viện Công nghệ Việt - Hàn (VKIT)", "Viện Văn hóa - Nghệ thuật - Thể thao", "Viện Đại học Mở HUTECH" });
            comboBox1.Location = new Point(13, 293);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 28);
            comboBox1.TabIndex = 3;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(134, 239);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 14;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(12, 239);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 3;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(12, 175);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(12, 122);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(249, 27);
            txtHoTen.TabIndex = 13;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(13, 358);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(249, 27);
            txtDiemTB.TabIndex = 12;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(12, 62);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(249, 27);
            txtMaSV.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 335);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 8;
            label7.Text = "Điểm TB:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 270);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 7;
            label6.Text = "Khoa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 99);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 6;
            label5.Text = "Họ Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 5;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 216);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Mã Số SV:";
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(290, 102);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(692, 472);
            dgvSinhVien.TabIndex = 3;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // lblTrangthai
            // 
            lblTrangthai.AutoSize = true;
            lblTrangthai.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangthai.Location = new Point(13, 577);
            lblTrangthai.Name = "lblTrangthai";
            lblTrangthai.Size = new Size(84, 25);
            lblTrangthai.TabIndex = 4;
            lblTrangthai.Text = "Sẵn sàng";
            lblTrangthai.Click += label8_Click;
            // 
            // lblTongso
            // 
            lblTongso.AutoSize = true;
            lblTongso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongso.Location = new Point(658, 574);
            lblTongso.Name = "lblTongso";
            lblTongso.Size = new Size(183, 28);
            lblTongso.TabIndex = 5;
            lblTongso.Text = "Tổng số sinh viên: 0";
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(lblTongso);
            Controls.Add(lblTrangthai);
            Controls.Add(dgvSinhVien);
            Controls.Add(grpThongTin);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormChinh";
            Text = "Quản Lý Sinh Viên";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label label1;
        private GroupBox grpThongTin;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtDiemTB;
        private TextBox txtMaSV;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnThem;
        private Button btnThemKhoa;
        private DataGridView dgvSinhVien;
        private Label lblTrangthai;
        private Label lblTongso;
    }
}
