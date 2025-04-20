using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.Pump;

namespace WinFormsApp31_03
{
    public partial class OperatingUpdatePage : Form
    {
        private readonly User _user;
        private readonly UserRole _userRole;
        private readonly int? _dataId = null;

        /// <summary>
        /// OperatingCreatePage
        /// </summary>
        public OperatingUpdatePage(int? dataId)
        {
            InitializeComponent();
            //_user = user;
            _dataId = dataId;
            _userRole = UserRole.Admin;
            ResetBtn.Enabled = false;
            LoadPumps();
            LoadOperating();
        }

        private void LoadOperating()
        {
            if (_dataId != null)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.OperatingData.Where(p => p.IsDelete == false && p.DataId == _dataId).Select(p => p.ToViewDto()).FirstOrDefault();
                    var operating = new OperatingInfoDto
                    {
                        PumpId = ett.PumpId,
                        RecordTime = ett.RecordTime,
                        FlowRate = ett.FlowRate,
                        Pressure = ett.Pressure,
                        PowerConsumption = ett.PowerConsumption,
                        Temperature = ett.Temperature,
                        RunningHours = ett.RunningHours,
                        Efficiency = ett.Efficiency,
                    };

                    SetFormValue(operating);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu này", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPumps()
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
                    MessageBox.Show("Bạn không có quyền tạo mới", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (var db = new PumpContext())
                    {
                        int pumpId = Convert.ToInt32(cbPump.SelectedValue);
                        var selectedPump = cbPump.SelectedItem as SearchCbDto;
                        double pressure = Convert.ToDouble(txtPressure.Text.Trim());
                        DateTime recordTime = dpRecord.Value;
                        double temperature = Convert.ToDouble(txtTemperature.Text.Trim());
                        double flowrate = Convert.ToDouble(txtFlowRate.Text.Trim());
                        double consumption = Convert.ToDouble(txtConsumption.Text.Trim());
                        double runningHours = Convert.ToDouble(txtRunningHours.Text.Trim());
                        double efficiency = Convert.ToDouble(txtEfficiency.Text.Trim());

                        var ett = db.OperatingData.Where(p => p.IsDelete == false && p.DataId == _dataId).FirstOrDefault();
                        ett.Update(pumpId, recordTime, flowrate, pressure, consumption, temperature, runningHours, efficiency);
                        MessageBox.Show("Chỉnh sửa dữ liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.SaveChanges();
                        GoToOperatingPage();
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
            GoToOperatingPage();
        }

        private void GoToOperatingPage()
        {
            OperatingPage operatingPage = new OperatingPage();
            operatingPage.Show();
            this.Hide();
        }

        /// <summary>
        /// SetFormValue
        /// </summary>
        private void SetFormValue(OperatingInfoDto info)
        {
            txtFlowRate.Text = info.FlowRate.ToString();
            txtPressure.Text = info.Pressure.ToString();
            txtConsumption.Text = info.PowerConsumption.ToString();
            txtTemperature.Text = info.Temperature.ToString();
            txtRunningHours.Text = info.RunningHours.ToString();
            txtEfficiency.Text = info.Efficiency.ToString();
            if (info.PumpId.HasValue)
            {
                var stationIndex = cbPump.Items.Cast<dynamic>().ToList().FindIndex(item => item.PumpId == info.PumpId.Value);
                if (stationIndex >= 0)
                {
                    cbPump.SelectedIndex = stationIndex;
                }
                else
                {
                    cbPump.SelectedIndex = 0;
                }
            }
            else
            {
                cbPump.SelectedIndex = 0;
            }
        }

        private void Clear()
        {
            SetFormValue(OperatingInfoDto.DefaultInfo());
            ResetBtn.Enabled = false;
        }

        // Điều kiện bật tắt nút reset
        private void CheckEnableReset(object sender, EventArgs e)
        {
            ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtFlowRate.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtPressure.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtConsumption.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtTemperature.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtEfficiency.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtRunningHours.Text.Trim());
        }

    }
}
