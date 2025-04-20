using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.Pump;

namespace WinFormsApp31_03
{
    public partial class OperatingCreatePage : Form
    {
        private readonly User _user;
        private readonly UserRole _userRole;

        /// <summary>
        /// OperatingCreatePage
        /// </summary>
        public OperatingCreatePage()
        {
            InitializeComponent();
            //_user = user;
            _userRole = UserRole.Admin;
            ResetBtn.Enabled = false;
            LoadPumps();
            Clear();
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
                using (var db = new PumpContext())
                {
                    OperatingData ett = new OperatingData();

                    int pumpId = Convert.ToInt32(cbPump.SelectedValue);
                    var selectedPump = cbPump.SelectedItem as SearchCbDto;
                    double pressure = Convert.ToDouble(txtPressure.Text.Trim());
                    DateTime recordTime = dpRecord.Value;
                    double temperature = Convert.ToDouble(txtTemperature.Text.Trim());
                    double flowrate = Convert.ToDouble(txtFlowRate.Text.Trim());
                    double consumption = Convert.ToDouble(txtConsumption.Text.Trim());
                    double runningHours = Convert.ToDouble(txtRunningHours.Text.Trim());
                    double efficiency = Convert.ToDouble(txtEfficiency.Text.Trim());

                    ett = OperatingData.Create(pumpId, recordTime, flowrate, pressure, consumption, temperature, runningHours, efficiency);
                    db.OperatingData.Add(ett);
                    MessageBox.Show("Tạo dữ liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();
                    GoToOperatingPage();
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
        private void SetFormValue(string? flowrate, string? pressure, string? consumption, string? temperature, string? runningHours, string? efficiency)
        {

            txtFlowRate.Text = flowrate;
            txtPressure.Text = pressure;
            txtConsumption.Text = consumption;
            txtTemperature.Text = temperature;
            txtRunningHours.Text = runningHours;
            txtEfficiency.Text = efficiency;
        }

        private void Clear()
        {
            SetFormValue(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
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
