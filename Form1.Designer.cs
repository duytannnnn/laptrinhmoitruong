
namespace tuan5_Lab03_02_
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSave = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuFormat = new ToolStripMenuItem();
            fontDlg = new FontDialog();
            richText = new RichTextBox();
            toolStrip1 = new ToolStrip();
            btnOpen = new ToolStripButton();
            btnSave = new ToolStripButton();
            cmbFonts = new ToolStripComboBox();
            cmbSize = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnItalic = new ToolStripButton();
            btnUnderline = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblWordCount = new ToolStripStatusLabel();
            openDlg = new OpenFileDialog();
            saveDlg = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, mnuFormat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, mnuSave, mnuExit });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.Size = new Size(129, 22);
            mnuNew.Text = "Tạo mới";
            mnuNew.Click += mnuNew_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(129, 22);
            mnuOpen.Text = "Mở tập tin";
            mnuOpen.Click += mnuOpen_Click;
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.Size = new Size(129, 22);
            mnuSave.Text = "Lưu";
            mnuSave.Click += mnuSave_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(129, 22);
            mnuExit.Text = "Thoát";
            // 
            // mnuFormat
            // 
            mnuFormat.Name = "mnuFormat";
            mnuFormat.Size = new Size(74, 20);
            mnuFormat.Text = "Định dạng";
            mnuFormat.Click += mnuFormat_Click;
            // 
            // fontDlg
            // 
            fontDlg.Apply += fontDlg_Apply;
            // 
            // richText
            // 
            richText.Dock = DockStyle.Fill;
            richText.Location = new Point(0, 49);
            richText.Name = "richText";
            richText.Size = new Size(800, 379);
            richText.TabIndex = 1;
            richText.Text = "";
            richText.TextChanged += richText_TextChanged;
            richText.KeyPress += richText_KeyPress;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnOpen, btnSave, cmbFonts, cmbSize, btnBold, btnItalic, btnUnderline });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(23, 22);
            btnOpen.Text = "Mở File";
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(23, 22);
            btnSave.Text = "Lưu";
            btnSave.Click += btnSave_Click;
            // 
            // cmbFonts
            // 
            cmbFonts.Name = "cmbFonts";
            cmbFonts.Size = new Size(150, 25);
            cmbFonts.SelectedIndexChanged += cmbFonts_SelectedIndexChanged;
            cmbFonts.Click += cmbFonts_Click;
            // 
            // cmbSize
            // 
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(75, 25);
            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;
            // 
            // btnBold
            // 
            btnBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBold.Image = (Image)resources.GetObject("btnBold.Image");
            btnBold.ImageTransparentColor = Color.Magenta;
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(23, 22);
            btnBold.Text = "Bold";
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItalic.Image = (Image)resources.GetObject("btnItalic.Image");
            btnItalic.ImageTransparentColor = Color.Magenta;
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(23, 22);
            btnItalic.Text = "Italic";
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUnderline.Image = (Image)resources.GetObject("btnUnderline.Image");
            btnUnderline.ImageTransparentColor = Color.Magenta;
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(23, 22);
            btnUnderline.Text = "Underline";
            btnUnderline.Click += btnUnderline_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblWordCount });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblWordCount
            // 
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(46, 17);
            lblWordCount.Text = "Số từ: 0";
            // 
            // openDlg
            // 
            openDlg.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richText);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Soạn thảo văn bản";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSave;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuFormat;
        private FontDialog fontDlg;
        private RichTextBox richText;
        private ToolStrip toolStrip1;
        private ToolStripButton btnOpen;
        private ToolStripButton btnSave;
        private ToolStripComboBox cmbSize;
        private ToolStripButton btnBold;
        private ToolStripButton btnItalic;
        private ToolStripButton btnUnderline;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblWordCount;
        private ToolStripComboBox cmbFonts;
        private OpenFileDialog openDlg;
        private SaveFileDialog saveDlg;
    }
}
