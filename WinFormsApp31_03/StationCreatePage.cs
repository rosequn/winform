using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    public partial class StationCreatePage : Form
    {
        /// <summary>
        /// Initialize
        /// </summary>
        /// User user(param)
        public StationCreatePage()
        {
            InitializeComponent();
            ResetBtn.Enabled = false;
            Clear();
        }

        // Nút lưu
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PumpContext())
                {
                    string stationName = txtName.Text.Trim();
                    string location = txtLocation.Text.Trim();
                    string description = txtDescription.Text.Trim();
                    if (!string.IsNullOrEmpty(stationName) && !string.IsNullOrEmpty(location))
                    {
                        var query = db.PumpStations.Where(p => p.IsDelete == false);
                        var ett = query.FirstOrDefault(p => p.StationName == stationName);

                        if (ett != null)
                        {
                            MessageBox.Show("Tên trạm bơm đã tồn tại vui lòng chọn một tên khác");
                        }
                        else
                        {
                            ett = PumpStation.Create(stationName, location, description, Properties.Settings.Default.UserId);
                            db.PumpStations.Add(ett);
                            MessageBox.Show("Tạo mới trạm bơm", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.SaveChanges();
                            ClosePage();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng ký không được để trống ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đặt lại
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            ClosePage();
        }

        private void ClosePage()
        {
            this.Close();
        }

        /// <summary>
        /// SetFormValue
        /// </summary>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="description"></param>
        private void SetFormValue(string? name, string? location, string? description)
        {
            txtName.Text = name;
            txtLocation.Text = description;
            txtDescription.Text = description;
        }

        private void Clear()
        {
            SetFormValue(string.Empty, string.Empty, string.Empty);
            ResetBtn.Enabled = false;
        }

        // Điều kiện bật tắt nút reset
        private void CheckEnableReset(object sender, EventArgs e)
        {
            ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtName.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtLocation.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtDescription.Text.Trim());
        }
    }
}
