namespace lab02_04
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
            lblPhim = new Label();
            lblGheDaChon1 = new Label();
            lblTongTien = new Label();
            panelSoDoGhe = new Panel();
            cboPhim = new ComboBox();
            btnXacNhan = new Button();
            btnHuyChon = new Button();
            lblGheDaChon = new Label();
            lblTongTien1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhim.Location = new Point(25, 30);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(60, 28);
            lblPhim.TabIndex = 0;
            lblPhim.Text = "Phim:";
            // 
            // lblGheDaChon1
            // 
            lblGheDaChon1.AutoSize = true;
            lblGheDaChon1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGheDaChon1.Location = new Point(494, 146);
            lblGheDaChon1.Name = "lblGheDaChon1";
            lblGheDaChon1.Size = new Size(131, 28);
            lblGheDaChon1.TabIndex = 1;
            lblGheDaChon1.Text = "Ghế Đã Chọn:";
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(494, 306);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(250, 45);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "0 Đ";
            // 
            // panelSoDoGhe
            // 
            panelSoDoGhe.BorderStyle = BorderStyle.FixedSingle;
            panelSoDoGhe.Location = new Point(25, 86);
            panelSoDoGhe.Name = "panelSoDoGhe";
            panelSoDoGhe.Size = new Size(407, 271);
            panelSoDoGhe.TabIndex = 3;
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.DropDownWidth = 300;
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(121, 39);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(311, 28);
            cboPhim.TabIndex = 4;
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.MediumSeaGreen;
            btnXacNhan.Location = new Point(494, 364);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(224, 45);
            btnXacNhan.TabIndex = 5;
            btnXacNhan.Text = "Xác nhận đặt vé";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuyChon
            // 
            btnHuyChon.BackColor = SystemColors.ButtonShadow;
            btnHuyChon.Location = new Point(494, 458);
            btnHuyChon.Name = "btnHuyChon";
            btnHuyChon.Size = new Size(224, 45);
            btnHuyChon.TabIndex = 6;
            btnHuyChon.Text = "Hủy chọn ghế";
            btnHuyChon.UseVisualStyleBackColor = false;
            btnHuyChon.Click += btnHuyChon_Click;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.Location = new Point(494, 183);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(300, 65);
            lblGheDaChon.TabIndex = 7;
            lblGheDaChon.Text = "123";
            // 
            // lblTongTien1
            // 
            lblTongTien1.AutoSize = true;
            lblTongTien1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien1.Location = new Point(494, 265);
            lblTongTien1.Name = "lblTongTien1";
            lblTongTien1.Size = new Size(102, 28);
            lblTongTien1.TabIndex = 8;
            lblTongTien1.Text = "Tổng Tiền:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(82, 470);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 10;
            label1.Text = "Trống";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 470);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 11;
            label2.Text = "Đã Chọn";
            // 
            // label4
            // 
            label4.BackColor = Color.Red;
            label4.Location = new Point(362, 470);
            label4.Name = "label4";
            label4.Size = new Size(23, 20);
            label4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 470);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 14;
            label5.Text = "Đã bán";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonFace;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(53, 470);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 15;
            // 
            // label6
            // 
            label6.BackColor = Color.Gold;
            label6.Location = new Point(198, 470);
            label6.Name = "label6";
            label6.Size = new Size(23, 20);
            label6.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 533);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTongTien1);
            Controls.Add(lblGheDaChon);
            Controls.Add(btnHuyChon);
            Controls.Add(btnXacNhan);
            Controls.Add(cboPhim);
            Controls.Add(panelSoDoGhe);
            Controls.Add(lblTongTien);
            Controls.Add(lblGheDaChon1);
            Controls.Add(lblPhim);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt Vé Xem Phim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhim;
        private Label lblGheDaChon1;
        private Label lblTongTien;
        private Panel panelSoDoGhe;
        private ComboBox cboPhim;
        private Button btnXacNhan;
        private Button btnHuyChon;
        private Label lblGheDaChon;
        private Label lblTongTien1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label6;
    }
}
