using System.Drawing.Imaging;

namespace LAB03_03
{
    partial class Form1
    {```csharp
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace LAB03_03
    {
        public partial class Form1 : Form
        {
            private enum CongCuVe
            {
                ButVe, DuongThang, HinhChuNhat, HinhTron, CucTay
            }

            private CongCuVe congCu = CongCuVe.ButVe;
            private Color mauVe = Color.Black;
            private int doDay = 3;

            private Bitmap bitmap;
            private Graphics g;
            private Panel canvas;

            private bool dangVe = false;
            private Point diemDau, diemCuoi;

            private Button[] cacNut;
            private Button btnMau, btnXoa, btnLuu;
            private Panel oMau;
            private TrackBar thanhDoDay;
            private Label lblDoDay;

            public Form1()
            {
                InitializeComponent();

                // Tạo giao diện tự động
                Text = "Ứng Dụng Vẽ Tranh Mini";
                ClientSize = new Size(900, 550);
                StartPosition = FormStartPosition.CenterScreen;

                // Tạo lại các nút công cụ
                button1.Text = "Bút vẽ";
                button2.Text = "Đường thẳng";
                button3.Text = "Chữ nhật";
                button4.Text = "Hình tròn";
                button5.Text = "Cục tẩy";

                Button[] nutCu = { button1, button2, button3, button4, button5 };

                for (int i = 0; i < nutCu.Length; i++)
                {
                    nutCu[i].Location = new Point(10, 15 + i * 42);
                    nutCu[i].Size = new Size(145, 32);
                    nutCu[i].Click -= ChonCongCu;
                    nutCu[i].Click += ChonCongCu;
                }

                cacNut = nutCu;

                // Bảng chọn màu
                Label lblMau = new Label
                {
                    Text = "Màu vẽ:",
                    Location = new Point(10, 235),
                    AutoSize = true
                };
                Controls.Add(lblMau);

                oMau = new Panel
                {
                    Location = new Point(10, 258),
                    Size = new Size(35, 30),
                    BackColor = mauVe,
                    BorderStyle = BorderStyle.FixedSingle
                };
                Controls.Add(oMau);

                btnMau = new Button
                {
                    Text = "Chọn màu",
                    Location = new Point(52, 258),
                    Size = new Size(103, 30)
                };
                btnMau.Click += ChonMau;
                Controls.Add(btnMau);

                // Thanh độ dày nét
                Label lblDay = new Label
                {
                    Text = "Độ dày nét:",
                    Location = new Point(10, 305),
                    AutoSize = true
                };
                Controls.Add(lblDay);

                thanhDoDay = new TrackBar
                {
                    Location = new Point(5, 325),
                    Size = new Size(150, 35),
                    Minimum = 1,
                    Maximum = 20,
                    Value = 3
                };
                thanhDoDay.Scroll += (s, e) =>
                {
                    doDay = thanhDoDay.Value;
                    lblDoDay.Text = "Độ dày: " + doDay;
                };
                Controls.Add(thanhDoDay);

                lblDoDay = new Label
                {
                    Text = "Độ dày: 3",
                    Location = new Point(10, 360),
                    AutoSize = true
                };
                Controls.Add(lblDoDay);

                // Nút xóa và lưu
                btnXoa = new Button
                {
                    Text = "Xóa tất cả",
                    Location = new Point(10, 405),
                    Size = new Size(145, 35),
                    BackColor = Color.LightCoral
                };
                btnXoa.Click += XoaTatCa;
                Controls.Add(btnXoa);

                btnLuu = new Button
                {
                    Text = "Lưu ảnh",
                    Location = new Point(10, 447),
                    Size = new Size(145, 35),
                    BackColor = Color.LightGreen
                };
                btnLuu.Click += LuuAnh;
                Controls.Add(btnLuu);

                // Vùng vẽ
                canvas = new Panel
                {
                    Location = new Point(170, 10),
                    Size = new Size(ClientSize.Width - 180,
                                    ClientSize.Height - 20),
                    Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                             AnchorStyles.Left | AnchorStyles.Right,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };
                Controls.Add(canvas);

                bitmap = new Bitmap(canvas.Width, canvas.Height);
                g = Graphics.FromImage(bitmap);
                g.Clear(Color.White);

                canvas.Paint += VeLaiCanvas;
                canvas.MouseDown += BatDauVe;
                canvas.MouseMove += DangVe;
                canvas.MouseUp += KetThucVe;

                ChonNutDangChon();
            }

            private void ChonCongCu(object sender, EventArgs e)
            {
                Button nut = sender as Button;

                if (nut == button1) congCu = CongCuVe.ButVe;
                else if (nut == button2) congCu = CongCuVe.DuongThang;
                else if (nut == button3) congCu = CongCuVe.HinhChuNhat;
                else if (nut == button4) congCu = CongCuVe.HinhTron;
                else if (nut == button5) congCu = CongCuVe.CucTay;

                ChonNutDangChon();
            }

            private void ChonNutDangChon()
            {
                for (int i = 0; i < cacNut.Length; i++)
                    cacNut[i].BackColor = SystemColors.Control;

                cacNut[(int)congCu].BackColor = Color.LightBlue;
            }

            private void ChonMau(object sender, EventArgs e)
            {
                using (ColorDialog cd = new ColorDialog())
                {
                    cd.Color = mauVe;
                    if (cd.ShowDialog() == DialogResult.OK)
                    {
                        mauVe = cd.Color;
                        oMau.BackColor = mauVe;
                    }
                }
            }

            private void BatDauVe(object sender, MouseEventArgs e)
            {
                if (e.Button != MouseButtons.Left) return;

                dangVe = true;
                diemDau = e.Location;
                diemCuoi = e.Location;
            }

            private void DangVe(object sender, MouseEventArgs e)
            {
                if (!dangVe) return;

                if (congCu == CongCuVe.ButVe ||
                    congCu == CongCuVe.CucTay)
                {
                    Color mau = congCu == CongCuVe.CucTay
                        ? Color.White : mauVe;

                    using (Pen pen = new Pen(mau, doDay))
                    {
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        g.DrawLine(pen, diemCuoi, e.Location);
                    }

                    diemCuoi = e.Location;
                }
                else
                {
                    diemCuoi = e.Location;
                }

                canvas.Invalidate();
            }

            private void KetThucVe(object sender, MouseEventArgs e)
            {
                if (!dangVe) return;

                diemCuoi = e.Location;

                if (congCu != CongCuVe.ButVe &&
                    congCu != CongCuVe.CucTay)
                {
                    using (Pen pen = new Pen(mauVe, doDay))
                    {
                        Rectangle r = TaoHinh(diemDau, diemCuoi);

                        if (congCu == CongCuVe.DuongThang)
                            g.DrawLine(pen, diemDau, diemCuoi);
                        else if (congCu == CongCuVe.HinhChuNhat)
                            g.DrawRectangle(pen, r);
                        else if (congCu == CongCuVe.HinhTron)
                            g.DrawEllipse(pen, r);
                    }
                }

                dangVe = false;
                canvas.Invalidate();
            }

            private Rectangle TaoHinh(Point a, Point b)
            {
                return new Rectangle(
                    Math.Min(a.X, b.X),
                    Math.Min(a.Y, b.Y),
                    Math.Abs(a.X - b.X),
                    Math.Abs(a.Y - b.Y));
            }

            private void VeLaiCanvas(object sender, PaintEventArgs e)
            {
                e.Graphics.DrawImageUnscaled(bitmap, 0, 0);

                if (dangVe && congCu != CongCuVe.ButVe &&
                    congCu != CongCuVe.CucTay)
                {
                    using (Pen pen = new Pen(mauVe, doDay))
                    {
                        Rectangle r = TaoHinh(diemDau, diemCuoi);

                        if (congCu == CongCuVe.DuongThang)
                            e.Graphics.DrawLine(pen, diemDau, diemCuoi);
                        else if (congCu == CongCuVe.HinhChuNhat)
                            e.Graphics.DrawRectangle(pen, r);
                        else if (congCu == CongCuVe.HinhTron)
                            e.Graphics.DrawEllipse(pen, r);
                    }
                }
            }

            private void XoaTatCa(object sender, EventArgs e)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ tranh?",
                    "Xác nhận", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    g.Clear(Color.White);
                    canvas.Invalidate();
                }
            }

            private void LuuAnh(object sender, EventArgs e)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Ảnh PNG (*.png)|*.png";
                    sfd.FileName = "TranhVe.png";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        bitmap.Save(sfd.FileName, ImageFormat.Png);
                        MessageBox.Show("Lưu ảnh thành công!");
                    }
                }
            }

            protected override void OnFormClosed(FormClosedEventArgs e)
            {
                g?.Dispose();
                bitmap?.Dispose();
                base.OnFormClosed(e);
            }
        }
    }
```

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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(36, 29);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(36, 80);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(36, 132);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(36, 197);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(36, 261);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
