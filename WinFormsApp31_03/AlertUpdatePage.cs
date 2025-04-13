using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.Pump;

namespace WinFormsApp31_03
{
    public partial class AlertUpdatePage : Form
    {
        private readonly User _user;
        private readonly UserRole _userRole;
        private readonly int? _alertId = null;

        /// <summary>
        /// Initialize
        /// </summary>
        /// User user(param)
        public AlertUpdatePage(int? alertId)
        {
            InitializeComponent();
            //_user = user;
            _userRole = UserRole.Admin;
            _alertId = alertId;
            ResetBtn.Enabled = false;
            LoadAlertType();
            LoadPump();
            LoadAlert();
        }

        private void LoadAlertType()
        {
            var list = EnumHelper.GetEnumListWithDescriptions<AlertType>();
            cbAlertType.DataSource = list;
            cbAlertType.DisplayMember = "Value";
            cbAlertType.ValueMember = "Key";
        }
        private void LoadAlert()
        {
            if (_alertId != null)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.Alerts.Where(p => p.IsDelete == false && p.AlertId == _alertId).Select(p => p.ToViewDto()).FirstOrDefault();
                    SetFormValue(ett.PumpId, ett.AlertType, ett.AlertMessage);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu này", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (_userRole != UserRole.Admin)
                {
                    MessageBox.Show("Bạn không có quyền chỉnh sửa", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                using (var db = new PumpContext())
                {

                    int alertType = Convert.ToInt32(cbAlertType.SelectedValue);
                    var selectedStation = cbPump.SelectedItem as SearchCbDto;
                    int pumpId = Convert.ToInt32(selectedStation.PumpId);

                    var ett = db.Alerts.Where(p => p.IsDelete == false && p.AlertId == _alertId).FirstOrDefault();
                    ett.Update(pumpId, alertType, txtMessage.Text.Trim(), 1);
                    MessageBox.Show("Chỉnh sửa thông báo thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();
                    GoToPumpPage();
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
            GoToPumpPage();
        }

        private void GoToPumpPage()
        {
            PumpPage pumpPage = new PumpPage();
            pumpPage.Show();
            this.Hide();
        }

        private void SetFormValue(int? pumpId, int? alertType, string? message)
        {
            txtMessage.Text = message;
            cbAlertType.SelectedIndex = alertType ?? 0;
            var pumpIndex = cbPump.Items.Cast<dynamic>().ToList().FindIndex(item => item.PumpId == pumpId);
            if (pumpIndex >= 0)
            {
                cbPump.SelectedIndex = pumpIndex;
            }
            else
            {
                cbPump.SelectedIndex = 0;
            }
        }

        private void Clear()
        {
            SetFormValue(null, null, string.Empty);
            ResetBtn.Enabled = false;
        }

        // Điều kiện bật tắt nút reset
        private void CheckEnableReset(object sender, EventArgs e)
        {
            ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtMessage.Text.Trim());
        }
    }
}
