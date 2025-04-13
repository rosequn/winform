using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.PumpStation;

namespace WinFormsApp31_03
{
    public partial class PumpUpdatePage : Form
    {
        private readonly User _user;
        private readonly UserRole _userRole;
        private readonly int? _pumpId = null;

        /// <summary>
        /// Initialize
        /// </summary>
        /// User user(param)
        public PumpUpdatePage(int? pumpId)
        {
            InitializeComponent();
            //_user = user;
            _userRole = UserRole.Admin;
            _pumpId = pumpId;
            ResetBtn.Enabled = false;
            LoadStation();
            LoadPumpType();
            LoadPumpStatus();
            LoadPump();
        }

        private void LoadPumpType()
        {
            var list = EnumHelper.GetEnumListWithDescriptions<PumpType>();
            cbPumpType.DataSource = list;
            cbPumpType.DisplayMember = "Value";
            cbPumpType.ValueMember = "Key";
        }
        private void LoadPumpStatus()
        {
            var list = EnumHelper.GetEnumListWithDescriptions<PumpStatus>();
            cbStatus.DataSource = list;
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
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

        private void LoadPump()
        {
            if (_pumpId != null)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.Pumps.Where(p => p.IsDelete == false && p.PumpId == _pumpId).Select(p => p.ToViewDto()).FirstOrDefault();
                    var pump = new PumpInfoDto
                    {
                        PumpName = ett.PumpName,
                        Description = ett.Description,
                        Manufacturer = ett.Manufacturer,
                        Capacity = ett.Capacity,
                        SerialNumber = ett.SerialNumber,
                        Status = ett.Status,
                        StationId = ett.StationId,
                        Type = ett.PumpType,
                        ExpiredDate = ett.WarrantyExpireDate
                    };

                    SetFormValue(pump);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy máy bơm này", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int pumpType = Convert.ToInt32(cbPumpType.SelectedValue);
                    var selectedStation = cbStation.SelectedItem as SearchCbDto;
                    int stationId = Convert.ToInt32(selectedStation.StationId);
                    float capacity = float.Parse(txtCapacity.Text.Trim());
                    int status = Convert.ToInt32(cbStatus.SelectedValue);
                    DateTime warrantyExpireDate = dpGuarantee.Value;
                    string serialNumber = txtSerialNumber.Text.Trim();

                    var existSerialNumber = db.Pumps.Where(p => p.SerialNumber == serialNumber && p.PumpId != _pumpId).FirstOrDefault();
                    if (existSerialNumber != null)
                    {
                        MessageBox.Show("Số seri đã tồn tại vui lòng chọn 1 số series khács", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var ett = db.Pumps.Where(p => p.IsDelete == false && p.PumpId == _pumpId).FirstOrDefault();
                        ett.Update(txtName.Text.Trim(), pumpType, capacity, txtManufracture.Text.Trim(), serialNumber, txtDescription.Text.Trim(), warrantyExpireDate, status, stationId, 1);
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật máy bơm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// <param name="info"></param>
        private void SetFormValue(PumpInfoDto info)
        {
            txtName.Text = info.PumpName;
            txtCapacity.Text = info.Capacity.ToString();
            txtDescription.Text = info.Description;
            txtManufracture.Text = info.Manufacturer;
            txtSerialNumber.Text = info.SerialNumber;
            cbStatus.SelectedIndex = info.Status;
            cbPumpType.SelectedIndex = info.Type ?? 0;
            dpGuarantee.Value = info.ExpiredDate ?? DateTime.Now;

            if (info.StationId.HasValue)
            {
                var stationIndex = cbStation.Items.Cast<dynamic>().ToList().FindIndex(item => item.StationId == info.StationId.Value);
                if (stationIndex >= 0)
                {
                    cbStation.SelectedIndex = stationIndex;
                }
                else
                {
                    cbStation.SelectedIndex = 0;
                }
            }
            else
            {
                cbStation.SelectedIndex = 0;
            }
        }

        private void Clear()
        {

            SetFormValue(PumpInfoDto.DefaultInfo());
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
