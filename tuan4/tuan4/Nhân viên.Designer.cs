namespace tuan4
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_msnv = new TextBox();
            txt_luongcoban = new TextBox();
            txt_tennhanvien = new TextBox();
            btn_dongy = new Button();
            btn_boqua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(39, 73);
            label1.Name = "label1";
            label1.Size = new Size(101, 38);
            label1.TabIndex = 0;
            label1.Text = "MSNV:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(39, 151);
            label2.Name = "label2";
            label2.Size = new Size(204, 38);
            label2.TabIndex = 1;
            label2.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(39, 212);
            label3.Name = "label3";
            label3.Size = new Size(197, 38);
            label3.TabIndex = 2;
            label3.Text = "Lương Cơ Bản:";
            label3.Click += label3_Click;
            // 
            // txt_msnv
            // 
            txt_msnv.Location = new Point(274, 84);
            txt_msnv.Name = "txt_msnv";
            txt_msnv.Size = new Size(417, 27);
            txt_msnv.TabIndex = 3;
            txt_msnv.TextChanged += txt_msnv_TextChanged;
            // 
            // txt_luongcoban
            // 
            txt_luongcoban.Location = new Point(274, 223);
            txt_luongcoban.Name = "txt_luongcoban";
            txt_luongcoban.Size = new Size(417, 27);
            txt_luongcoban.TabIndex = 4;
            // 
            // txt_tennhanvien
            // 
            txt_tennhanvien.Location = new Point(274, 162);
            txt_tennhanvien.Name = "txt_tennhanvien";
            txt_tennhanvien.Size = new Size(417, 27);
            txt_tennhanvien.TabIndex = 5;
            // 
            // btn_dongy
            // 
            btn_dongy.Location = new Point(193, 316);
            btn_dongy.Name = "btn_dongy";
            btn_dongy.Size = new Size(126, 70);
            btn_dongy.TabIndex = 6;
            btn_dongy.Text = "Đồng Ý";
            btn_dongy.UseVisualStyleBackColor = true;
            btn_dongy.Click += btn_dongy_Click;
            // 
            // btn_boqua
            // 
            btn_boqua.Location = new Point(462, 316);
            btn_boqua.Name = "btn_boqua";
            btn_boqua.Size = new Size(132, 70);
            btn_boqua.TabIndex = 7;
            btn_boqua.Text = "Bỏ qua";
            btn_boqua.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_boqua);
            Controls.Add(btn_dongy);
            Controls.Add(txt_tennhanvien);
            Controls.Add(txt_luongcoban);
            Controls.Add(txt_msnv);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Nhân Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_msnv;
        private TextBox txt_luongcoban;
        private TextBox txt_tennhanvien;
        private Button btn_dongy;
        private Button btn_boqua;
    }
}