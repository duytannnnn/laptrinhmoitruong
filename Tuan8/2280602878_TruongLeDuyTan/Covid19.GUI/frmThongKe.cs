using Covid19.BLL;

namespace Covid19.GUI
{
    public partial class frmThongKe : Form
    {
        private readonly TinhTrangBLL ttBLL = new TinhTrangBLL();
        private readonly BenhNhanBLL bnBLL = new BenhNhanBLL();

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            cboTinhTrang.DisplayMember = "TenTT";
            cboTinhTrang.ValueMember = "MaTT";
            cboTinhTrang.DataSource = ttBLL.GetAll();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = bnBLL.GetDuLieuThongKe((int)cboTinhTrang.SelectedValue);
        }
    }
}