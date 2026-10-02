namespace lab02_03
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            cboKhoa = new ComboBox();
            txtDiemTB = new TextBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            label6 = new Label();
            lblHoTen = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnLamMoi = new Button();
            txtTimKiem = new TextBox();
            label5 = new Label();
            btnXoa = new Button();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colKhoa = new DataGridViewTextBoxColumn();
            colDiemTB = new DataGridViewTextBoxColumn();
            label7 = new Label();
            cboLocKhoa = new ComboBox();
            lblTongSo = new Label();
            lblThongKe = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboKhoa);
            groupBox1.Controls.Add(txtDiemTB);
            groupBox1.Controls.Add(rdoNu);
            groupBox1.Controls.Add(rdoNam);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblHoTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(111, 124);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(252, 28);
            cboKhoa.TabIndex = 12;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(699, 81);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(106, 27);
            txtDiemTB.TabIndex = 11;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(496, 122);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 10;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(496, 82);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 9;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(111, 84);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(252, 27);
            dtpNgaySinh.TabIndex = 8;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(526, 34);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(254, 27);
            txtHoTen.TabIndex = 7;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(111, 37);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(229, 27);
            txtMaSV.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(624, 84);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Điểm TB:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(409, 37);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(78, 20);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Họ và Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 124);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Khoa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 84);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 84);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Giới Tính:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Chartreuse;
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(52, 186);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(113, 59);
            btnThem.TabIndex = 1;
            btnThem.Text = "✚ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.RoyalBlue;
            btnCapNhat.Font = new Font("Segoe UI", 10.2F);
            btnCapNhat.ForeColor = SystemColors.ButtonHighlight;
            btnCapNhat.Location = new Point(262, 186);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(113, 59);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "✎ Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.ActiveBorder;
            btnLamMoi.Font = new Font("Segoe UI", 10.2F);
            btnLamMoi.ForeColor = SystemColors.ButtonHighlight;
            btnLamMoi.Location = new Point(679, 186);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(113, 59);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "↻ Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(161, 269);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(214, 27);
            txtTimKiem.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 272);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 6;
            label5.Text = "🔎 Tìm kiếm:";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.ForeColor = SystemColors.ButtonFace;
            btnXoa.Location = new Point(476, 186);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 59);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "✕ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colNgaySinh, colGioiTinh, colKhoa, colDiemTB });
            dgvSinhVien.Location = new Point(12, 335);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(860, 187);
            dgvSinhVien.TabIndex = 8;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // colMaSV
            // 
            colMaSV.DataPropertyName = "MaSV";
            colMaSV.HeaderText = "Mã SV";
            colMaSV.MinimumWidth = 6;
            colMaSV.Name = "colMaSV";
            colMaSV.ReadOnly = true;
            colMaSV.Width = 150;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ và Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            colHoTen.Width = 125;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            colNgaySinh.Width = 125;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            colGioiTinh.Width = 125;
            // 
            // colKhoa
            // 
            colKhoa.DataPropertyName = "Khoa";
            colKhoa.HeaderText = "Khoa";
            colKhoa.MinimumWidth = 6;
            colKhoa.Name = "colKhoa";
            colKhoa.ReadOnly = true;
            colKhoa.Width = 125;
            // 
            // colDiemTB
            // 
            colDiemTB.DataPropertyName = "DiemTB";
            colDiemTB.HeaderText = "Điểm TB";
            colDiemTB.MinimumWidth = 6;
            colDiemTB.Name = "colDiemTB";
            colDiemTB.ReadOnly = true;
            colDiemTB.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 272);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 9;
            label7.Text = "Lọc khoa:";
            // 
            // cboLocKhoa
            // 
            cboLocKhoa.FormattingEnabled = true;
            cboLocKhoa.Location = new Point(508, 268);
            cboLocKhoa.Name = "cboLocKhoa";
            cboLocKhoa.Size = new Size(151, 28);
            cboLocKhoa.TabIndex = 10;
            // 
            // lblTongSo
            // 
            lblTongSo.AutoSize = true;
            lblTongSo.Location = new Point(34, 581);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(138, 20);
            lblTongSo.TabIndex = 11;
            lblTongSo.Text = "Tổng số sinh viên: 0";
            // 
            // lblThongKe
            // 
            lblThongKe.AutoSize = true;
            lblThongKe.Location = new Point(310, 581);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(103, 20);
            lblThongKe.TabIndex = 12;
            lblThongKe.Text = "thống kê khoa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 653);
            Controls.Add(lblThongKe);
            Controls.Add(lblTongSo);
            Controls.Add(cboLocKhoa);
            Controls.Add(label7);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnXoa);
            Controls.Add(label5);
            Controls.Add(txtTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblHoTen;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private Label label6;
        private ComboBox cboKhoa;
        private TextBox txtDiemTB;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Button btnThem;
        private Button btnCapNhat;

        private Button btnLamMoi;
        private TextBox txtTimKiem;
        private Label label5;
        private Button btnXoa;
        private DataGridView dgvSinhVien;
        private Label label7;
        private ComboBox cboLocKhoa;
        private Label lblTongSo;
        private Label lblThongKe;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colKhoa;
        private DataGridViewTextBoxColumn colDiemTB;
    }
}
