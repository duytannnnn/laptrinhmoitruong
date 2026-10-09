namespace lab03
{
    partial class FormQuanLyKhoaHoc
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
            label4 = new Label();
            cbx_SoTinChi = new ComboBox();
            txt_MaKhoaHoc = new TextBox();
            txt_TenKhoaHoc = new TextBox();
            lst_KhoaHoc = new ListView();
            btnThemKhoaHoc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Khóa Học:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 211);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 1;
            label2.Text = "Danh Sách Khóa Học:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 146);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Số Tín Chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 87);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên Khóa Học:";
            // 
            // cbx_SoTinChi
            // 
            cbx_SoTinChi.FormattingEnabled = true;
            cbx_SoTinChi.Items.AddRange(new object[] { "0", "1", "3" });
            cbx_SoTinChi.Location = new Point(248, 152);
            cbx_SoTinChi.Name = "cbx_SoTinChi";
            cbx_SoTinChi.Size = new Size(151, 28);
            cbx_SoTinChi.TabIndex = 4;
            // 
            // txt_MaKhoaHoc
            // 
            txt_MaKhoaHoc.Location = new Point(250, 28);
            txt_MaKhoaHoc.Name = "txt_MaKhoaHoc";
            txt_MaKhoaHoc.Size = new Size(277, 27);
            txt_MaKhoaHoc.TabIndex = 5;
            // 
            // txt_TenKhoaHoc
            // 
            txt_TenKhoaHoc.Location = new Point(250, 84);
            txt_TenKhoaHoc.Name = "txt_TenKhoaHoc";
            txt_TenKhoaHoc.Size = new Size(412, 27);
            txt_TenKhoaHoc.TabIndex = 6;
            // 
            // lst_KhoaHoc
            // 
            lst_KhoaHoc.Location = new Point(2, 235);
            lst_KhoaHoc.Name = "lst_KhoaHoc";
            lst_KhoaHoc.Size = new Size(796, 216);
            lst_KhoaHoc.TabIndex = 7;
            lst_KhoaHoc.UseCompatibleStateImageBehavior = false;
            // 
            // btnThemKhoaHoc
            // 
            btnThemKhoaHoc.BackColor = SystemColors.ActiveCaption;
            btnThemKhoaHoc.Location = new Point(451, 151);
            btnThemKhoaHoc.Name = "btnThemKhoaHoc";
            btnThemKhoaHoc.Size = new Size(190, 29);
            btnThemKhoaHoc.TabIndex = 8;
            btnThemKhoaHoc.Text = "Thêm";
            btnThemKhoaHoc.UseVisualStyleBackColor = false;
            btnThemKhoaHoc.Click += btnThemKhoaHoc_Click;
            // 
            // FormQuanLyKhoaHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThemKhoaHoc);
            Controls.Add(lst_KhoaHoc);
            Controls.Add(txt_TenKhoaHoc);
            Controls.Add(txt_MaKhoaHoc);
            Controls.Add(cbx_SoTinChi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormQuanLyKhoaHoc";
            Text = "Quản Lý Khóa Học";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbx_SoTinChi;
        private TextBox txt_MaKhoaHoc;
        private TextBox txt_TenKhoaHoc;
        private ListView lst_KhoaHoc;
        private Button btnThemKhoaHoc;
    }
}