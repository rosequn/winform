using Microsoft.EntityFrameworkCore;
using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.PumpStation;

namespace WinFormsApp31_03
{
    public partial class MaintainPage : Form
    {
        private int? _maintainId = null;
        private int? _stationId = null;
        private string? _keyword = null;

        /// <summary>
        /// Initialize
        /// </summary>
        public MaintainPage()
        {
            InitializeComponent();
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
            CompletedBtn.Enabled = false;
            LoadComponents();
            LoadMaintenanceHistories();
            LoadStation();
        }

        private void LoadComponents()
        {
            DataGridViewStyler.ApplyCustomStyle(dgMaintain);
            dgMaintain.RowPrePaint += DataGridViewStyler.RowRepaint;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadMaintenanceHistories();
        }

        // Load data
        private void LoadMaintenanceHistories()
        {
            dgMaintain.AutoGenerateColumns = false;
            using (var db = new PumpContext())
            {
                var query = db.MaintenanceHistories
                    .Include(p => p.Pump)
                    .Include(p => p.PerformedByNavigation)
                    .Where(p => p.IsDelete == false);
                if (_stationId != null)
                {
                    query = query.Where(p => p.Pump.StationId == _stationId);
                }

                if (_keyword != null)
                {
                    query = query.Where(u => u.Pump.PumpName.ToLower().Contains(_keyword) || u.Description.ToLower().Contains(_keyword));
                }

                var ett = query.Select(p => p.ToSearchDto()).ToList();
                dgMaintain.DataSource = ett;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.MaintenanceHistories.FirstOrDefault(p => p.MaintenanceId == _maintainId && p.IsDelete == false);
                    if (ett != null)
                    {
                        ett.Delete(1);
                        db.SaveChanges();
                        LoadMaintenanceHistories();
                        _maintainId = null;
                        MessageBox.Show("Xóa dữ liệu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu này");
                    }
                }
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateBtn.Enabled = false;
            MaintainCreatePage createPage = new MaintainCreatePage();
            createPage.StartPosition = FormStartPosition.CenterScreen;
            createPage.Show();
            createPage.FormClosed += (s, eArgs) =>
            {
                CreateBtn.Enabled = true;
            };
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (_maintainId != null)
            {
                UpdateBtn.Enabled = false;
                DeleteBtn.Enabled = false;
                MaintainUpdatePage updatePage = new MaintainUpdatePage(_maintainId);
                updatePage.StartPosition = FormStartPosition.CenterScreen;
                updatePage.Show();
                updatePage.UpdateMaintainComplete += (s, args) =>
                {
                    _maintainId = null;
                    LoadMaintenanceHistories();
                };

                updatePage.FormClosed += (s, eArgs) =>
                {
                    UpdateBtn.Enabled = _maintainId != null;
                    DeleteBtn.Enabled = _maintainId != null;
                };
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
                if (dgMaintain.CurrentRow.Index != -1)
                {
                    dgMaintain.AutoGenerateColumns = false;
                    using (var db = new PumpContext())
                    {
                        int maintainId = Convert.ToInt32(dgMaintain.CurrentRow.Cells["MaintenanceID"].Value);
                        var ett = db.MaintenanceHistories.Where(p => p.IsDelete == false && p.MaintenanceId == maintainId).Select(p => p.ToViewDto()).FirstOrDefault();
                        if (ett != null)
                        {
                            _maintainId = maintainId;
                            DeleteBtn.Enabled = true;
                            UpdateBtn.Enabled = true;
                        }

                        if (ett.Status != (int)MaintainStatus.Completed)
                        {
                            CompletedBtn.Enabled = true;
                        }
                        else
                        {
                            CompletedBtn.Enabled = false;
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

                    LoadMaintenanceHistories();
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

        private void CompletedBtn_Click(object sender, EventArgs e)
        {
            using (var db = new PumpContext())
            {
                var ett = db.MaintenanceHistories.FirstOrDefault(p => p.MaintenanceId == _maintainId && p.IsDelete == false);
                if (ett != null)
                {
                    ett.UpdateStatus((int)MaintainStatus.Completed, Properties.Settings.Default.UserId);
                    db.SaveChanges();
                    LoadMaintenanceHistories();
                    _maintainId = null;
                    MessageBox.Show("Cập nhật trạng thái thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu này");
                }
            }
        }

        private void Search(object sender, EventArgs e)
        {
            _keyword = txtSearch.Text.Trim().ToLower();
            LoadMaintenanceHistories();
        }
    }
}
