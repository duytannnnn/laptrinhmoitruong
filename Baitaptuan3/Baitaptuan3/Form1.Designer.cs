namespace Baitaptuan3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            chkTheThao = new CheckBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            chkPhimAnh = new CheckBox();
            chkDuLich = new CheckBox();
            btnXuatThongTin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(56, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "Thông tin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(426, 77);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(56, 77);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Họ tên";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(377, 184);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "Sở Thích";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(56, 180);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(525, 77);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(128, 79);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(265, 27);
            txtHoTen.TabIndex = 6;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // chkTheThao
            // 
            chkTheThao.AutoSize = true;
            chkTheThao.Location = new Point(475, 187);
            chkTheThao.Name = "chkTheThao";
            chkTheThao.Size = new Size(92, 24);
            chkTheThao.TabIndex = 7;
            chkTheThao.Text = "Thể Thao";
            chkTheThao.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(171, 184);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 8;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(296, 184);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 9;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // chkPhimAnh
            // 
            chkPhimAnh.AutoSize = true;
            chkPhimAnh.Location = new Point(577, 187);
            chkPhimAnh.Name = "chkPhimAnh";
            chkPhimAnh.Size = new Size(94, 24);
            chkPhimAnh.TabIndex = 10;
            chkPhimAnh.Text = "Phim Ảnh";
            chkPhimAnh.UseVisualStyleBackColor = true;
            // 
            // chkDuLich
            // 
            chkDuLich.AutoSize = true;
            chkDuLich.Location = new Point(677, 187);
            chkDuLich.Name = "chkDuLich";
            chkDuLich.Size = new Size(80, 24);
            chkDuLich.TabIndex = 11;
            chkDuLich.Text = "Du Lịch";
            chkDuLich.UseVisualStyleBackColor = true;
            // 
            // btnXuatThongTin
            // 
            btnXuatThongTin.Location = new Point(577, 366);
            btnXuatThongTin.Name = "btnXuatThongTin";
            btnXuatThongTin.Size = new Size(166, 29);
            btnXuatThongTin.TabIndex = 12;
            btnXuatThongTin.Text = "Xuất Thông Tin";
            btnXuatThongTin.UseVisualStyleBackColor = true;
            btnXuatThongTin.Click += btnXuatThongTin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXuatThongTin);
            Controls.Add(chkDuLich);
            Controls.Add(chkPhimAnh);
            Controls.Add(radNu);
            Controls.Add(radNam);
            Controls.Add(chkTheThao);
            Controls.Add(txtHoTen);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private CheckBox chkTheThao;
        private RadioButton radNam;
        private RadioButton radNu;
        private CheckBox chkPhimAnh;
        private CheckBox chkDuLich;
        private Button btnXuatThongTin;
    }
}
