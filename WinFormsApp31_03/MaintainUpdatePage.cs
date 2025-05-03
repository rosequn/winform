using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.Pump;

namespace WinFormsApp31_03
{
    public partial class MaintainUpdatePage : Form
    {
        private readonly int? _maintainId = null;
        public event EventHandler UpdateMaintainComplete;

        /// <summary>
        /// Initialize
        /// </summary>
        public MaintainUpdatePage(int? maintainId)
        {
            InitializeComponent();
            _maintainId = maintainId;
            ResetBtn.Enabled = false;
            LoadAlertType();
            LoadPump();
            LoadAlert();
        }

        private void LoadAlertType()
        {
            var list = EnumHelper.GetEnumListWithDescriptions<AlertType>();
            cbMaintainType.DataSource = list;
            cbMaintainType.DisplayMember = "Value";
            cbMaintainType.ValueMember = "Key";
        }
        private void LoadAlert()
        {
            if (_maintainId != null)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.MaintenanceHistories.Where(p => p.IsDelete == false && p.MaintenanceId == _maintainId).Select(p => p.ToViewDto()).FirstOrDefault();
                    SetFormValue(ett.PumpId, ett.Type, ett.Description, ett.StartDate, ett.EndDate);
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
                using (var db = new PumpContext())
                {

                    int maintainType = Convert.ToInt32(cbMaintainType.SelectedValue);
                    var selectionPump = cbPump.SelectedItem as SearchCbDto;
                    int pumpId = Convert.ToInt32(selectionPump.PumpId);
                    DateTime startDate = dpStart.Value;
                    DateTime endDate = dpEnd.Value;

                    if (endDate <= startDate)
                    {
                        MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var ett = db.MaintenanceHistories.Where(p => p.IsDelete == false && p.MaintenanceId == _maintainId).FirstOrDefault();
                    ett.Update(pumpId, maintainType, startDate, endDate, txtDescription.Text.Trim(), Properties.Settings.Default.UserId);
                    MessageBox.Show("Chỉnh sửa dữ liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();
                    UpdateMaintainComplete?.Invoke(this, EventArgs.Empty);
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

        private void SetFormValue(int? pumpId, int? alertType, string? description, DateTime? startDate, DateTime? endDate)
        {
            txtDescription.Text = description;
            dpStart.Value = startDate ?? DateTime.Now;
            dpEnd.Value = endDate ?? DateTime.Now;
            cbMaintainType.SelectedIndex = alertType ?? 0;
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
            SetFormValue(null, null, string.Empty, null, null);
            ResetBtn.Enabled = false;
        }

        // Điều kiện bật tắt nút reset
        private void CheckEnableReset(object sender, EventArgs e)
        {
            ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtDescription.Text.Trim());
        }
    }
}
