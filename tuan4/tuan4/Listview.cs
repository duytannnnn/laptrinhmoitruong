using System;
using System.Windows.Forms;

namespace tuan4
{
    public partial class Listview : Form
    {
        public Listview()
        {
            InitializeComponent();

            btn_them.Click += btn_them_Click;
            btn_xoa.Click += btn_xoa_Click;
            btn_sua.Click += btn_sua_Click;
            btn_dong.Click += btn_dong_Click;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = false;

            this.Load += Listview_Load;
        }

        private void Listview_Load(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                NhanVien nv = frm.NV;

                int rowIndex = dataGridView1.Rows.Add(
                    nv.MSNV,
                    nv.TenNhanVien,
                    nv.LuongCoBan
                );

                dataGridView1.Rows[rowIndex].Cells[d1_msnv.Index].ReadOnly = true;
                dataGridView1.Rows[rowIndex].Cells[d2_tennv.Index].ReadOnly = true;
                dataGridView1.Rows[rowIndex].Cells[d3_luongcoban.Index].ReadOnly = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                NhanVien nv = frm.NV;

                int rowIndex = dataGridView1.Rows.Add(
                    nv.MSNV,
                    nv.TenNhanVien,
                    nv.LuongCoBan
                );

                dataGridView1.Rows[rowIndex].Cells[d1_msnv.Index].ReadOnly = true;
                dataGridView1.Rows[rowIndex].Cells[d2_tennv.Index].ReadOnly = true;
                dataGridView1.Rows[rowIndex].Cells[d3_luongcoban.Index].ReadOnly = true;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa nhân viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            row.Cells[d1_msnv.Index].ReadOnly = false;
            row.Cells[d2_tennv.Index].ReadOnly = false;
            row.Cells[d3_luongcoban.Index].ReadOnly = false;

            dataGridView1.CurrentCell = row.Cells[d1_msnv.Index];
            dataGridView1.BeginEdit(true);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đóng không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}