
namespace Covid19.GUI
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtMaBN = new TextBox();
            label4 = new Label();
            txtTenBN = new TextBox();
            label5 = new Label();
            cboTinhTrang = new ComboBox();
            label7 = new Label();
            txtGhiChu = new TextBox();
            label6 = new Label();
            cboLayNhiemTu = new ComboBox();
            btnCapNhat = new Button();
            btnThoat = new Button();
            dgvBenhNhan = new DataGridView();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBenhNhan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(180, 42);
            label1.Name = "label1";
            label1.Size = new Size(558, 37);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Ca Bệnh COVID-19 tại Việt Nam";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(950, 28);
            menuStrip1.TabIndex = 1;
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêToolStripMenuItem, thoátToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaBN);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenBN);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboTinhTrang);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboLayNhiemTu);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Location = new Point(20, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 400);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 35);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã BN";
            // 
            // txtMaBN
            // 
            txtMaBN.Location = new Point(115, 32);
            txtMaBN.MaxLength = 6;
            txtMaBN.Name = "txtMaBN";
            txtMaBN.Size = new Size(195, 27);
            txtMaBN.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 80);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 2;
            label4.Text = "Tên BN";
            // 
            // txtTenBN
            // 
            txtTenBN.Location = new Point(115, 77);
            txtTenBN.Name = "txtTenBN";
            txtTenBN.Size = new Size(195, 27);
            txtTenBN.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 125);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Tình trạng";
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinhTrang.Location = new Point(115, 122);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(195, 28);
            cboTinhTrang.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 170);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 6;
            label7.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(115, 167);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.ScrollBars = ScrollBars.Vertical;
            txtGhiChu.Size = new Size(195, 75);
            txtGhiChu.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 260);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 8;
            label6.Text = "Lây nhiễm từ";
            // 
            // cboLayNhiemTu
            // 
            cboLayNhiemTu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLayNhiemTu.Location = new Point(115, 257);
            cboLayNhiemTu.Name = "cboLayNhiemTu";
            cboLayNhiemTu.Size = new Size(195, 28);
            cboLayNhiemTu.TabIndex = 9;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(30, 330);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(120, 35);
            btnCapNhat.TabIndex = 10;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(180, 330);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 35);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvBenhNhan
            // 
            dgvBenhNhan.AllowUserToAddRows = false;
            dgvBenhNhan.AllowUserToDeleteRows = false;
            dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBenhNhan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBenhNhan.Location = new Point(370, 105);
            dgvBenhNhan.MultiSelect = false;
            dgvBenhNhan.Name = "dgvBenhNhan";
            dgvBenhNhan.ReadOnly = true;
            dgvBenhNhan.RowHeadersWidth = 51;
            dgvBenhNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBenhNhan.Size = new Size(560, 400);
            dgvBenhNhan.TabIndex = 3;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(224, 26);
            thốngKêToolStripMenuItem.Text = "Thống kê ";
            thốngKêToolStripMenuItem.Click += ThongkeToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 530);
            Controls.Add(dgvBenhNhan);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(966, 569);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Ca Bệnh COVID-19 tại Việt Nam";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBenhNhan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtTenBN;
        private TextBox txtMaBN;
        private Label label4;
        private Label label3;
        private ComboBox cboTinhTrang;
        private Button btnThoat;
        private Button btnCapNhat;
        private Label label6;
        private ComboBox cboLayNhiemTu;
        private Label label7;
        private TextBox txtGhiChu;
        private DataGridView dgvBenhNhan;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}
