namespace lab03_02
{
    partial class FormChiTietSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtDiemTB = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            cboKhoa = new ComboBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 102);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ và Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 160);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 212);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới Tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 270);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Khoa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 332);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Điểm TB:";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(223, 45);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(281, 27);
            txtMaSV.TabIndex = 6;
            txtMaSV.TextChanged += txtMaSV_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(223, 99);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(281, 27);
            txtHoTen.TabIndex = 7;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(223, 329);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(138, 27);
            txtDiemTB.TabIndex = 12;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(223, 155);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(281, 27);
            dtpNgaySinh.TabIndex = 8;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(223, 212);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 9;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(330, 212);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 10;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Items.AddRange(new object[] { "Công nghệ thông tin", "Hệ thống thông tin quản lý", "Kiến trúc - Mỹ thuật", "Xây dựng", "Quản trị kinh doanh", "Marketing - Kinh doanh quốc tế", "Tài chính - Thương mại", "Quản trị Du lịch - Nhà hàng - Khách sạn", "Luật", "Dược", "Y", "Điều dưỡng - Kỹ thuật y học", "Thú y", "Thẩm mỹ và Khoa học sự sống", "Tiếng Anh", "Nhật Bản học", "Trung Quốc học", "Hàn Quốc học", "Khoa học Xã hội và Quan hệ Công chúng", "Truyền thông và Thiết kế", "Viện Kỹ thuật HUTECH", "Viện Khoa học Ứng dụng HUTECH", "Viện Khoa học Sức khỏe HUTECH", "Viện Đào tạo Quốc tế HUTECH", "Viện Công nghệ Việt - Nhật (VJIT)", "Viện Công nghệ Việt - Hàn (VKIT)", "Viện Văn hóa - Nghệ thuật - Thể thao", "Viện Đại học Mở HUTECH" });
            cboKhoa.Location = new Point(223, 267);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(281, 28);
            cboKhoa.TabIndex = 11;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(223, 385);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 35);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.DialogResult = DialogResult.Cancel;
            btnHuy.Location = new Point(350, 385);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 35);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // FormChiTietSinhVien
            // 
            AcceptButton = btnLuu;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnHuy;
            ClientSize = new Size(560, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtDiemTB);
            Controls.Add(cboKhoa);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormChiTietSinhVien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông tin sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;

        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtDiemTB;

        private DateTimePicker dtpNgaySinh;

        private RadioButton rdoNam;
        private RadioButton rdoNu;

        private ComboBox cboKhoa;

        private Button btnLuu;
        private Button btnHuy;
    }
}