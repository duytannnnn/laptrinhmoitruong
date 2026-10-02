namespace Thuchanhtuan2
{
    public partial class Form1 : Form
    {
        private List<string> lichSu = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSo1.Text) || string.IsNullOrWhiteSpace(txtSo2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ 2 số!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtSo1.Text, out double so1) || !double.TryParse(txtSo2.Text, out double so2))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Button btnDuocBam = (Button)sender;
            string kyHieu = btnDuocBam.Text;
            double ketQua = 0;

            switch (kyHieu)
            {
                case "+":
                    ketQua = so1 + so2;
                    break;

                case "-":
                    ketQua = so1 - so2;
                    break;

                case "x":
                    ketQua = so1 * so2;
                    break;

                case "÷":
                    if (so2 == 0)
                    {
                        MessageBox.Show(
                            "Không thể chia cho 0!",
                            "Lỗi tính toán",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    ketQua = so1 / so2;
                    break;
            }
            lblKetQua.Text = $"Kết quả: {so1} {kyHieu} {so2} = {ketQua}";

            string dong = $"{so1} {kyHieu} {so2} = {ketQua}";
            lichSu.Add(dong);
            lstLichSu.Items.Insert(0, dong);
        }

        private void btnXoaLichSu_Click(object sender, EventArgs e)
        {
            if (lichSu.Count == 0)
            {
                MessageBox.Show(
                    "Chưa có lịch sử để xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            var ketQuaXacNhan = MessageBox.Show(
                "Bạn có chắc muốn xóa toàn bộ lịch sử tính toán?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQuaXacNhan == DialogResult.Yes)
            {
                lichSu.Clear();
                lstLichSu.Items.Clear();
            }
        }

    }
}
