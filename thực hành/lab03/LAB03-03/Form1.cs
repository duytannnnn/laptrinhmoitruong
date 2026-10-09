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
            ButVe,
            DuongThang,
            HinhChuNhat,
            HinhTron,
            CucTay
        }

        private CongCuVe congCuHienTai = CongCuVe.ButVe;

        private Color mauVe = Color.Black;
        private int doDayNet = 3;

        private Bitmap canvasBitmap;
        private Graphics canvasGraphics;

        private bool dangVe = false;
        private Point diemBatDau;
        private Point diemCuoi;

        private Pen butVe;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
