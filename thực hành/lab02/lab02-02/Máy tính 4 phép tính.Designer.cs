namespace Thuchanhtuan2
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
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            lblLichSu = new Label();
            lstLichSu = new ListBox();
            btnChia = new Button();
            lblKetQua = new Label();
            btnXoaLichSu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 25);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "Số thứ 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 86);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 2";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(203, 32);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(493, 27);
            txtSo1.TabIndex = 2;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(203, 87);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(493, 27);
            txtSo2.TabIndex = 3;
            // 
            // btnCong
            // 
            btnCong.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCong.Location = new Point(55, 134);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(99, 67);
            btnCong.TabIndex = 4;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnPhepTinh_Click;
            // 
            // btnTru
            // 
            btnTru.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTru.Location = new Point(234, 134);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(99, 67);
            btnTru.TabIndex = 5;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnPhepTinh_Click;
            // 
            // btnNhan
            // 
            btnNhan.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNhan.Location = new Point(411, 134);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(99, 67);
            btnNhan.TabIndex = 6;
            btnNhan.Text = "×";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnPhepTinh_Click;
            // 
            // lblLichSu
            // 
            lblLichSu.AutoSize = true;
            lblLichSu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLichSu.Location = new Point(55, 281);
            lblLichSu.Name = "lblLichSu";
            lblLichSu.Size = new Size(215, 31);
            lblLichSu.TabIndex = 10;
            lblLichSu.Text = "LỊch Sử Thanh Toán:";
            // 
            // lstLichSu
            // 
            lstLichSu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstLichSu.FormattingEnabled = true;
            lstLichSu.Location = new Point(293, 281);
            lstLichSu.Name = "lstLichSu";
            lstLichSu.Size = new Size(300, 144);
            lstLichSu.TabIndex = 11;
            // 
            // btnChia
            // 
            btnChia.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChia.Location = new Point(597, 134);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(99, 67);
            btnChia.TabIndex = 12;
            btnChia.Text = "÷";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnPhepTinh_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKetQua.ForeColor = SystemColors.HotTrack;
            lblKetQua.Location = new Point(55, 231);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(86, 28);
            lblKetQua.TabIndex = 13;
            lblKetQua.Text = "Kết Quả:";
            // 
            // btnXoaLichSu
            // 
            btnXoaLichSu.Location = new Point(597, 230);
            btnXoaLichSu.Name = "btnXoaLichSu";
            btnXoaLichSu.Size = new Size(94, 29);
            btnXoaLichSu.TabIndex = 14;
            btnXoaLichSu.Text = "Xóa LỊch Sử";
            btnXoaLichSu.UseVisualStyleBackColor = true;
            btnXoaLichSu.Click += btnXoaLichSu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoaLichSu);
            Controls.Add(lblKetQua);
            Controls.Add(btnChia);
            Controls.Add(lstLichSu);
            Controls.Add(lblLichSu);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Máy tính 4 phép tính";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button button3;
        private Button button1;
        private Label label3;
        private Label lblLichSu;
        private ListBox lstLichSu;
        private Button btnChia;
        private Label lblKetQua;
        private Button btnXoaLichSu;
    }
}
