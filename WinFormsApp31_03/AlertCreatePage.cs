using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.Pump;

namespace WinFormsApp31_03
{
    public partial class AlertCreatePage : Form
    {
        /// <summary>
        /// Initialize
        /// </summary>
        /// User user(param)
        public AlertCreatePage()
        {
            InitializeComponent();
            ResetBtn.Enabled = false;
            LoadAlertType();
            LoadPump();
            Clear();
        }

        private void LoadAlertType()
        {
            var list = EnumHelper.GetEnumListWithDescriptions<AlertType>();
            cbAlertType.DataSource = list;
            cbAlertType.DisplayMember = "Value";
            cbAlertType.ValueMember = "Key";
        }
        private void LoadPump()
        {
            using (var db = new PumpContext())
            {
                var ett = db.Pumps.Where(p => p.IsDelete == false).Select(p => p.ToSearchCbDto()).ToList();
                cbPump.DataSource = ett;
                cbPump.DisplayMember = "PumpName";
                cbPump.ValueMember = "PumpId";
            }
        }
        // Nút lưu
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PumpContext())
                {
                    Alert ett = new Alert();
                    int alertType = Convert.ToInt32(cbAlertType.SelectedValue);
                    var selectedStation = cbPump.SelectedItem as SearchCbDto;
                    int pumpId = Convert.ToInt32(selectedStation.PumpId);

                    ett = Alert.Create(pumpId, alertType, txtMessage.Text.Trim(), Properties.Settings.Default.UserId);
                    db.Alerts.Add(ett);
                    MessageBox.Show("Tạo thông báo thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();
                    ClosePage();
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

        private void SetFormValue(string? message)
        {
            txtMessage.Text = message;
        }

        private void Clear()
        {
            SetFormValue(string.Empty);
            ResetBtn.Enabled = false;
        }

        // Điều kiện bật tắt nút reset
        private void CheckEnableReset(object sender, EventArgs e)
        {
            ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtMessage.Text.Trim());
        }
    }
}
