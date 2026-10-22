using Covid19.BLL;

namespace Covid19.GUI
{
    public partial class frmMain : Form
    {
        private readonly BenhNhanBLL bnBLL = new BenhNhanBLL();
        private readonly TinhTrangBLL ttBLL = new TinhTrangBLL();

        public frmMain()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cboTinhTrang.DisplayMember = "TenTT";
            cboTinhTrang.ValueMember = "MaTT";
            cboTinhTrang.DataSource = ttBLL.GetAll();
            LoadAll();
        }

        private void LoadAll()
        {
            cboLayNhiemTu.DataSource = bnBLL.GetDanhSachLayNhiem();
            dgvBenhNhan.DataSource = bnBLL.GetDanhSach();
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaBN.Clear();
            txtTenBN.Clear();
            txtGhiChu.Clear();
            cboTinhTrang.SelectedIndex = 0;
            cboLayNhiemTu.SelectedIndex = 0;
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var bn = (BenhNhanDTO)dgvBenhNhan.Rows[e.RowIndex].DataBoundItem;
            txtMaBN.Text = bn.MaBN;
            txtTenBN.Text = bn.TenBN;
            cboTinhTrang.SelectedValue = bn.MaTT;
            txtGhiChu.Text = bn.GhiChu;
            cboLayNhiemTu.SelectedItem = bn.BNTXG ?? "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var kq = bnBLL.LuuBenhNhan(
                txtMaBN.Text,
                txtTenBN.Text,
                (int)cboTinhTrang.SelectedValue,
                txtGhiChu.Text,
                cboLayNhiemTu.SelectedItem?.ToString() ?? "");

            if (!kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(kq.ThongBao);
            LoadAll();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThongkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThongKe().ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}