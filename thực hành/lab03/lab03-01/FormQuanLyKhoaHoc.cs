using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab03
{
    public partial class FormQuanLyKhoaHoc : Form
    {
        public FormQuanLyKhoaHoc()
        {
            InitializeComponent();

            // Thiết lập số tín chỉ
            cbx_SoTinChi.Items.Add("2");
            cbx_SoTinChi.Items.Add("3");
            cbx_SoTinChi.Items.Add("4");
            cbx_SoTinChi.Items.Add("5");

            // Thiết lập hiển thị danh sách
            lst_KhoaHoc.View = View.Details;
            lst_KhoaHoc.FullRowSelect = true;
            lst_KhoaHoc.GridLines = true;

            lst_KhoaHoc.Columns.Add("Mã khóa học", 150);
            lst_KhoaHoc.Columns.Add("Tên khóa học", 300);
            lst_KhoaHoc.Columns.Add("Số tín chỉ", 120);
        }

     

   private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaKhoaHoc.Text) ||
                string.IsNullOrWhiteSpace(txt_TenKhoaHoc.Text) ||
                cbx_SoTinChi.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin khóa học!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }


            ListViewItem item = new ListViewItem(
                txt_MaKhoaHoc.Text.Trim()
            );

            item.SubItems.Add(txt_TenKhoaHoc.Text.Trim());
            item.SubItems.Add(cbx_SoTinChi.Text);


            lst_KhoaHoc.Items.Add(item);


            txt_MaKhoaHoc.Clear();
            txt_TenKhoaHoc.Clear();
            cbx_SoTinChi.SelectedIndex = -1;

            txt_MaKhoaHoc.Focus();
        }
    }
}
