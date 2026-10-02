namespace lab02_01
{
    partial class dtpNgaySinh
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblKetQua = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtHoTen = new TextBox();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            dateTimePickerNgaySinh = new DateTimePicker();
            chkTheThao = new CheckBox();
            chkDocSach = new CheckBox();
            chkAmNhac = new CheckBox();
            btnXacNhan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 30);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên:";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKetQua.ForeColor = SystemColors.Highlight;
            lblKetQua.Location = new Point(104, 371);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(0, 28);
            lblKetQua.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 205);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 2;
            label3.Text = "Sở Thích";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 149);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 89);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 4;
            label5.Text = "Giới tính:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(241, 31);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(480, 27);
            txtHoTen.TabIndex = 6;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoNam.Location = new Point(299, 94);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(76, 29);
            rdoNam.TabIndex = 7;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam ";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoNu.Location = new Point(511, 94);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(57, 29);
            rdoNu.TabIndex = 8;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Short;
            dateTimePickerNgaySinh.Location = new Point(299, 153);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(353, 31);
            dateTimePickerNgaySinh.TabIndex = 9;
            // 
            // chkTheThao
            // 
            chkTheThao.AutoSize = true;
            chkTheThao.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTheThao.Location = new Point(354, 205);
            chkTheThao.Name = "chkTheThao";
            chkTheThao.Size = new Size(106, 29);
            chkTheThao.TabIndex = 10;
            chkTheThao.Text = "Thể Thao";
            chkTheThao.UseVisualStyleBackColor = true;
            // 
            // chkDocSach
            // 
            chkDocSach.AutoSize = true;
            chkDocSach.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDocSach.Location = new Point(354, 260);
            chkDocSach.Name = "chkDocSach";
            chkDocSach.Size = new Size(106, 29);
            chkDocSach.TabIndex = 12;
            chkDocSach.Text = "Đọc sách";
            chkDocSach.UseVisualStyleBackColor = true;
            // 
            // chkAmNhac
            // 
            chkAmNhac.AutoSize = true;
            chkAmNhac.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAmNhac.Location = new Point(354, 308);
            chkAmNhac.Name = "chkAmNhac";
            chkAmNhac.Size = new Size(107, 29);
            chkAmNhac.TabIndex = 13;
            chkAmNhac.Text = "Âm Nhạc";
            chkAmNhac.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.Location = new Point(558, 260);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(133, 36);
            btnXacNhan.TabIndex = 14;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // dtpNgaySinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXacNhan);
            Controls.Add(chkAmNhac);
            Controls.Add(chkDocSach);
            Controls.Add(chkTheThao);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(txtHoTen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblKetQua);
            Controls.Add(label1);
            Name = "dtpNgaySinh";
            Text = "Form Thông Tin Cá Nhân";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblKetQua;
        private Label label3;
        private Label label4;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtHoTen;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private DateTimePicker dateTimePickerNgaySinh;
        private CheckBox chkTheThao;
        private CheckBox chkDocSach;
        private CheckBox chkAmNhac;
        private Button btnXacNhan;
    }
}
