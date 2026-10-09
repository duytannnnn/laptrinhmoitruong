namespace lab03
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
            menuStripChinh = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuMoSinhVien = new ToolStripMenuItem();
            mnuMoKhoaHoc = new ToolStripMenuItem();
            mnuCuaSo = new ToolStripMenuItem();
            mnuSapXepTang = new ToolStripMenuItem();
            mnuSapXepNgang = new ToolStripMenuItem();
            mnuSapXepDoc = new ToolStripMenuItem();
            mnuDongTatCa = new ToolStripMenuItem();
            menuStripChinh.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripChinh
            // 
            menuStripChinh.ImageScalingSize = new Size(20, 20);
            menuStripChinh.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuCuaSo });
            menuStripChinh.Location = new Point(0, 0);
            menuStripChinh.MdiWindowListItem = mnuCuaSo;
            menuStripChinh.Name = "menuStripChinh";
            menuStripChinh.Size = new Size(800, 28);
            menuStripChinh.TabIndex = 1;
            menuStripChinh.Text = "menuStrip2";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuMoSinhVien, mnuMoKhoaHoc });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(88, 24);
            mnuHeThong.Text = "Hệ Thống";
          
            // 
            // mnuMoSinhVien
            // 
            mnuMoSinhVien.Name = "mnuMoSinhVien";
            mnuMoSinhVien.Size = new Size(224, 26);
            mnuMoSinhVien.Text = "Quản Lý Sinh Viên";
            mnuMoSinhVien.Click += mnuMoSinhVien_Click;
            // 
            // mnuMoKhoaHoc
            // 
            mnuMoKhoaHoc.Name = "mnuMoKhoaHoc";
            mnuMoKhoaHoc.Size = new Size(224, 26);
            mnuMoKhoaHoc.Text = "Quản Lý Khóa Học";
            mnuMoKhoaHoc.Click += mnuMoKhoaHoc_Click;
            // 
            // mnuCuaSo
            // 
            mnuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuSapXepTang, mnuSapXepNgang, mnuSapXepDoc, mnuDongTatCa });
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new Size(70, 24);
            mnuCuaSo.Text = "Cửa Sổ";
            
            // 
            // mnuSapXepTang
            // 
            mnuSapXepTang.Name = "mnuSapXepTang";
            mnuSapXepTang.Size = new Size(191, 26);
            mnuSapXepTang.Text = "Sắp xếp tầng";
            mnuSapXepTang.Click += mnuSapXepTang_Click;
            // 
            // mnuSapXepNgang
            // 
            mnuSapXepNgang.Name = "mnuSapXepNgang";
            mnuSapXepNgang.Size = new Size(191, 26);
            mnuSapXepNgang.Text = "Sắp xếp ngang";
            mnuSapXepNgang.Click += mnuSapXepNgang_Click;
            // 
            // mnuSapXepDoc
            // 
            mnuSapXepDoc.Name = "mnuSapXepDoc";
            mnuSapXepDoc.Size = new Size(191, 26);
            mnuSapXepDoc.Text = "Sắp xếp dọc";
            mnuSapXepDoc.Click += mnuSapXepDoc_Click;
            // 
            // mnuDongTatCa
            // 
            mnuDongTatCa.Name = "mnuDongTatCa";
            mnuDongTatCa.Size = new Size(191, 26);
            mnuDongTatCa.Text = "Đóng tất cả";
            mnuDongTatCa.Click += mnuDongTatCa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripChinh);
            IsMdiContainer = true;
            MainMenuStrip = menuStripChinh;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý — HUTECH";
            WindowState = FormWindowState.Maximized;
            menuStripChinh.ResumeLayout(false);
            menuStripChinh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhóaHọcToolStripMenuItem;
        private ToolStripMenuItem cửaSỏToolStripMenuItem;
        private ToolStripMenuItem sắpXếpDọcToolStripMenuItem;
        private ToolStripMenuItem sắpXếpNgangToolStripMenuItem;
        private ToolStripMenuItem mnuSapXepNgang;
        private MenuStrip menuStripChinh;
        private ToolStripMenuItem mnuMoSinhVien;
        
        private ToolStripMenuItem mnuCuaSo;
        private ToolStripMenuItem mnuSapXepTang;
        private ToolStripMenuItem mnuSapXepDoc;
        private ToolStripMenuItem mnuDongTatCa;
        private ToolStripMenuItem mnuMoKhoaHoc;
    }
}
