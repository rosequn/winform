using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.Pump;

namespace WinFormsApp31_03
{
    public partial class MaintainCreatePage : Form
    {
        /// <summary>
        /// Initialize
        /// </summary>
        public MaintainCreatePage()
        {
            InitializeComponent();
            ResetBtn.Enabled = false;
            LoadMaintenanceHistoryType();
            LoadPump();
            Clear();
        }

        private void LoadMaintenanceHistoryType()
        {
            var list = EnumHelper.GetEnumListWithDescriptions<MaintainType>();
            cbMaintainType.DataSource = list;
            cbMaintainType.DisplayMember = "Value";
            cbMaintainType.ValueMember = "Key";
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
                    MaintenanceHistory ett = new MaintenanceHistory();
                    int maintainType = Convert.ToInt32(cbMaintainType.SelectedValue);
                    var selectedStation = cbPump.SelectedItem as SearchCbDto;
                    int pumpId = Convert.ToInt32(selectedStation.PumpId);
                    DateTime startDate = dpStart.Value;
                    DateTime endDate = dpEnd.Value;

                    if (endDate <= startDate)
                    {
                        MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ett = MaintenanceHistory.Create(pumpId, maintainType, startDate, endDate, txtDescription.Text.Trim());
                    db.MaintenanceHistories.Add(ett);
                    MessageBox.Show("Tạo dữ liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtDescription.Text = message;
        }

        private void Clear()
        {
            SetFormValue(string.Empty);
            ResetBtn.Enabled = false;
        }

        // Điều kiện bật tắt nút reset
        private void CheckEnableReset(object sender, EventArgs e)
        {
            ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtDescription.Text.Trim());
        }
    }
}
