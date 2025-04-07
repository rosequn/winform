using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.PumpStation;

namespace WinFormsApp31_03
{
    public partial class PumpCreatePage : Form
    {
        private readonly User _user;
        private readonly UserRole _userRole;

        /// <summary>
        /// Initialize
        /// </summary>
        /// User user(param)
        public PumpCreatePage()
        {
            InitializeComponent();
            //_user = user;
            _userRole = UserRole.Admin;
            ResetBtn.Enabled = false;
            LoadStation();
            LoadPumpType();
            Clear();
        }

        private void LoadPumpType()
        {
            var list = EnumHelper.GetEnumListWithDescriptions<PumpType>();
            cbPumpType.DataSource = list;
            cbPumpType.DisplayMember = "Value";
            cbPumpType.ValueMember = "Key";
        }


        private void LoadStation()
        {
            using (var db = new PumpContext())
            {
                var ett = db.PumpStations.Where(p => p.IsDelete == false).Select(p => p.ToSearchCbDto()).ToList();
                cbStation.DataSource = ett;
                cbStation.DisplayMember = "StationName";
                cbStation.ValueMember = "StationId";
            }
        }

        // Nút lưu
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_userRole != UserRole.Admin)
                {
                    MessageBox.Show("Bạn không có quyền tạo mới", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                using (var db = new PumpContext())
                {
                    Pump ett = new Pump();
                    int stationId = Convert.ToInt32(cbStation.SelectedValue);
                    var selectedStation = cbStation.SelectedItem as SearchCbDto;
                    int pumpType = Convert.ToInt32(selectedStation.StationId);
                    float capacity = float.Parse(txtCapacity.Text.Trim());
                    DateTime warrantyExpireDate = dpGuarantee.Value;
                    string serialNumber = txtSerialNumber.Text.Trim();

                    var existSerialNumber = db.Pumps.Where(p => p.SerialNumber == serialNumber).FirstOrDefault();
                    if (existSerialNumber != null)
                    {
                        MessageBox.Show("Số seri đã tồn tại vui lòng chọn 1 số series khács", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ett = Pump.Create(txtName.Text.Trim(), pumpType, capacity, txtManufracture.Text.Trim(), serialNumber, txtDescription.Text.Trim(), warrantyExpireDate, stationId, 1);
                        db.Pumps.Add(ett);
                        MessageBox.Show("Tạo máy bơm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.SaveChanges();
                        GoToPumpPage();
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
            GoToPumpPage();
        }

        private void GoToPumpPage()
        {
            PumpPage pumpPage = new PumpPage();
            pumpPage.Show();
            this.Hide();
        }

        /// <summary>
        /// SetFormValue
        /// </summary>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="description"></param>
        private void SetFormValue(string? name, string? location, string? description, string? manufracture, string? serialNumber)
        {
            txtName.Text = name;
            txtCapacity.Text = location;
            txtDescription.Text = description;
            txtManufracture.Text = manufracture;
            txtSerialNumber.Text = serialNumber;
        }

        private void Clear()
        {
            SetFormValue(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            ResetBtn.Enabled = false;
        }

        // Điều kiện bật tắt nút reset
        private void CheckEnableReset(object sender, EventArgs e)
        {
            ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtName.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtCapacity.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtManufracture.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtSerialNumber.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtDescription.Text.Trim());
        }
    }
}
