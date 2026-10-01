using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace tuan5_Lab03_02_
{
    public partial class frmMain : Form
    {
        private string currentFontName = "Tahoma";
        private float currentFontSize = 14;
        public frmMain()
        {
            InitializeComponent();

            LoadFonts();
            LoadSizes();

            cmbFonts.Text = "Tahoma";
            cmbSize.Text = "14";

            richText.Font = new Font("Tahoma", 14);


        }

        private void mnuFormat_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        private void fontDlg_Apply(object sender, EventArgs e)
        {

        }
        private void LoadFonts()
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmbFonts.Items.Add(font.Name);
            }
        }
        private void LoadSizes()
        {
            int[] sizes =
            {
        8, 9, 10, 11, 12, 14, 16, 18,
        20, 22, 24, 26, 28, 36, 48, 72
    };

            foreach (int size in sizes)
            {
                cmbSize.Items.Add(size);
            }
        }
        private void richText_TextChanged(object sender, EventArgs e)
        {
            string text = richText.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                lblWordCount.Text = "S? t?: 0";
                return;
            }

            string[] words = text.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            );

            lblWordCount.Text = "S? t?: " + words.Length;
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            richText.Clear();

            richText.Font = new Font("Tahoma", 14);

            cmbFonts.Text = "Tahoma";
            cmbSize.Text = "14";

            richText.ForeColor = Color.Black;
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openDlg.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openDlg.FileName).ToLower() == ".rtf")
                {
                    richText.LoadFile(openDlg.FileName);
                }
                else
                {
                    richText.LoadFile(
                        openDlg.FileName,
                        RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            saveDlg.Filter =
        "Rich Text Format (*.rtf)|*.rtf";

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                richText.SaveFile(saveDlg.FileName);

                MessageBox.Show(
                    "L?u v?n b?n thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void cmbFonts_Click(object sender, EventArgs e)
        {

        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFonts.SelectedItem == null)
                return;

            string fontName = cmbFonts.SelectedItem.ToString();


            if (richText.SelectionLength > 0)
            {
                Font currentFont = richText.SelectionFont;

                if (currentFont != null)
                {
                    richText.SelectionFont =
                        new Font(
                            fontName,
                            currentFont.Size,
                            currentFont.Style
                        );
                }
            }
            else
            {

                currentFontName = fontName;
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSize.SelectedItem == null)
                return;

            float size = Convert.ToSingle(cmbSize.SelectedItem);


            if (richText.SelectionLength > 0)
            {
                Font currentFont = richText.SelectionFont;

                if (currentFont != null)
                {
                    richText.SelectionFont =
                        new Font(
                            currentFont.FontFamily,
                            size,
                            currentFont.Style
                        );
                }
            }
            else
            {

                currentFontSize = size;
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (richText.SelectionLength > 0)
            {

                Font currentFont = richText.SelectionFont;

                if (currentFont == null)
                    return;

                FontStyle style = currentFont.Style;

                if (currentFont.Bold)
                    style &= ~FontStyle.Bold;
                else
                    style |= FontStyle.Bold;

                richText.SelectionFont = new Font(currentFont, style);
            }
            else
            {

                Font currentFont = richText.SelectionFont ?? richText.Font;

                FontStyle style = currentFont.Style;

                if (currentFont.Bold)
                    style &= ~FontStyle.Bold;
                else
                    style |= FontStyle.Bold;

                richText.SelectionFont = new Font(currentFont, style);
            }
        }


        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (richText.SelectionLength > 0)
            {

                Font currentFont = richText.SelectionFont;

                if (currentFont == null)
                    return;

                FontStyle style = currentFont.Style;

                if (currentFont.Italic)
                    style &= ~FontStyle.Italic;
                else
                    style |= FontStyle.Italic;

                richText.SelectionFont = new Font(currentFont, style);
            }
            else
            {

                Font currentFont = richText.SelectionFont ?? richText.Font;

                FontStyle style = currentFont.Style;

                if (currentFont.Italic)
                    style &= ~FontStyle.Italic;
                else
                    style |= FontStyle.Italic;

                richText.SelectionFont = new Font(currentFont, style);
            }
        }


        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (richText.SelectionLength > 0)
            {

                Font currentFont = richText.SelectionFont;

                if (currentFont == null)
                    return;

                FontStyle style = currentFont.Style;

                if (currentFont.Underline)
                    style &= ~FontStyle.Underline;
                else
                    style |= FontStyle.Underline;

                richText.SelectionFont = new Font(currentFont, style);
            }
            else
            {

                Font currentFont = richText.SelectionFont ?? richText.Font;

                FontStyle style = currentFont.Style;

                if (currentFont.Underline)
                    style &= ~FontStyle.Underline;
                else
                    style |= FontStyle.Underline;

                richText.SelectionFont = new Font(currentFont, style);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            mnuOpen_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mnuSave_Click(sender, e);
        }

        private void richText_KeyPress(object sender, KeyPressEventArgs e)
        {
            richText.SelectionFont =
        new Font(
            currentFontName,
            currentFontSize,
            richText.SelectionFont?.Style ?? FontStyle.Regular
        );
        }
    }
}
