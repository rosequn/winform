using Microsoft.EntityFrameworkCore;
using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.PumpStation;

namespace WinFormsApp31_03
{
    public partial class AlertPage : Form
    {
        private readonly int _userId;
        private readonly UserRole _userRole;
        private int? _alertId = null;
        private int? _stationId = null;
        private string? _keyword = null;

        /// <summary>
        /// Initialize
        /// </summary>
        public AlertPage()
        {
            InitializeComponent();
            //_userId = userId;
            _userRole = UserRole.Admin;
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
            ResolvedBtn.Enabled = false;
            IgnoredBtn.Enabled = false;
            LoadAlerts();
            LoadStation();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadAlerts();
        }

        // Load data
        private void LoadAlerts()
        {
            dgAlert.AutoGenerateColumns = false;
            using (var db = new PumpContext())
            {
                var query = db.Alerts
                    .Include(p => p.Pump)
                    .Include(p => p.ModifiedByNavigation)
                    .Where(p => p.IsDelete == false);
                if (_stationId != null)
                {
                    query = query.Where(p => p.Pump.StationId == _stationId);
                }
                if (_keyword != null)
                {
                    query = query.Where(u => u.Pump.PumpName.ToLower().Contains(_keyword) || u.AlertMessage.ToLower().Contains(_keyword));
                }

                var ett = query.Select(p => p.ToSearchDto()).ToList();
                dgAlert.DataSource = ett;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.Alerts.FirstOrDefault(p => p.AlertId == _alertId && p.IsDelete == false);
                    if (ett != null)
                    {
                        ett.Delete(1);
                        db.SaveChanges();
                        LoadAlerts();
                        _alertId = null;
                        MessageBox.Show("Xóa dữ liệu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu này");
                    }
                }
            }
        }

        private void ResolvedBtn_Click(object sender, EventArgs e)
        {
            using (var db = new PumpContext())
            {
                var ett = db.Alerts.FirstOrDefault(p => p.AlertId == _alertId && p.IsDelete == false);
                if (ett != null)
                {
                    ett.UpdateStatus((int)AlertStatus.Resolved, 1);
                    db.SaveChanges();
                    LoadAlerts();
                    _alertId = null;
                    MessageBox.Show("Xử lý thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu này");
                }
            }
        }

        private void IgnoredBtn_Click(object sender, EventArgs e)
        {
            using (var db = new PumpContext())
            {
                var ett = db.Alerts.FirstOrDefault(p => p.AlertId == _alertId && p.IsDelete == false);
                if (ett != null)
                {
                    ett.UpdateStatus((int)AlertStatus.Ignored, 1);
                    db.SaveChanges();
                    LoadAlerts();
                    _alertId = null;
                    MessageBox.Show("Đã bỏ qua thông báo này");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu này");
                }
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            AlertCreatePage createPage = new AlertCreatePage();
            createPage.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (_alertId != null)
            {
                AlertUpdatePage updatePage = new AlertUpdatePage(_alertId);
                updatePage.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgPump_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgAlert.CurrentRow.Index != -1)
                {
                    dgAlert.AutoGenerateColumns = false;
                    using (var db = new PumpContext())
                    {
                        int alertId = Convert.ToInt32(dgAlert.CurrentRow.Cells["AlertId"].Value);
                        var ett = db.Alerts.Where(p => p.IsDelete == false && p.AlertId == alertId).Select(p => p.ToViewDto()).FirstOrDefault();
                        if (ett != null)
                        {
                            _alertId = alertId;
                            DeleteBtn.Enabled = true;
                            UpdateBtn.Enabled = true;
                        }

                        if (ett.Status != (int)AlertStatus.Resolved)
                        {
                            ResolvedBtn.Enabled = true;
                            IgnoredBtn.Enabled = true;
                        }
                        else
                        {
                            ResolvedBtn.Enabled = false;
                            IgnoredBtn.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy dữ liệu này", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStation.SelectedItem != null)
            {
                var selectedStation = cbStation.SelectedItem as SearchCbDto;
                if (selectedStation != null)
                {
                    _stationId = selectedStation.StationId;
                    if (_stationId == 0)
                    {
                        _stationId = null;
                    }

                    LoadAlerts();
                }
            }
        }

        private void LoadStation()
        {
            using (var db = new PumpContext())
            {
                var ett = db.PumpStations.Where(p => p.IsDelete == false).Select(p => p.ToSearchCbDto()).ToList();
                ett.Insert(0, new SearchCbDto { StationId = 0, StationName = "Tất cả" });

                cbStation.DataSource = ett;
                cbStation.DisplayMember = "StationName";
                cbStation.ValueMember = "StationId";
            }
        }

        private void Search(object sender, EventArgs e)
        {
            _keyword = txtSearch.Text.Trim().ToLower();
            LoadAlerts();
        }
    }
}
