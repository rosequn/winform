using Microsoft.EntityFrameworkCore;
using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.PumpStation;

namespace WinFormsApp31_03
{
    public partial class OperatingPage : Form
    {
        private readonly int _userId;
        private readonly UserRole _userRole;
        private int? _dataId = null;
        private int? _stationId = null;
        private string? _keyword = null;

        /// <summary>
        /// Initialize
        /// </summary>
        public OperatingPage()
        {
            InitializeComponent();
            //_userId = userId;
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
            LoadOperations();
            LoadStation();
            LoadComponents();
        }

        private void LoadComponents()
        {
            DataGridViewStyler.ApplyCustomStyle(dgOperating);
            dgOperating.RowPrePaint += DataGridViewStyler.RowRepaint;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadOperations();
        }

        // Load data
        private void LoadOperations()
        {
            dgOperating.AutoGenerateColumns = false;
            using (var db = new PumpContext())
            {
                var query = db.OperatingData.Include(p => p.Pump).Where(p => p.IsDelete == false);
                if (_stationId != null)
                {
                    query = query.Where(p => p.Pump.StationId == _stationId);
                }
                if (_keyword != null)
                {
                    query = query.Where(u => u.Pump.PumpName.ToLower().Contains(_keyword));
                }
                var ett = query.Select(p => p.ToSearchDto()).ToList();
                dgOperating.DataSource = ett;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.OperatingData.FirstOrDefault(p => p.DataId == _dataId && p.IsDelete == false);
                    if (ett != null)
                    {
                        ett.Delete(1);
                        db.SaveChanges();
                        MessageBox.Show("Xóa dữ liệu thành công");
                        LoadOperations();
                        _dataId = null;
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
            OperatingCreatePage createPage = new OperatingCreatePage();
            createPage.StartPosition = FormStartPosition.CenterScreen;
            createPage.FormClosed += (s, eArgs) =>
            {
                CreateBtn.Enabled = true;
            };

            createPage.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (_dataId != null)
            {
                UpdateBtn.Enabled = false;
                DeleteBtn.Enabled = false;
                OperatingUpdatePage updatePage = new OperatingUpdatePage(_dataId);
                updatePage.StartPosition = FormStartPosition.CenterScreen;
                updatePage.UpdateOperatingCompleted += (s, args) =>
                {
                    _dataId = null;
                    LoadOperations();
                };

                updatePage.FormClosed += (s, eArgs) =>
                {
                    UpdateBtn.Enabled = _dataId != null;
                    DeleteBtn.Enabled = _dataId != null;
                };

                updatePage.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgOperating_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgOperating.CurrentRow.Index != -1)
                {
                    dgOperating.AutoGenerateColumns = false;
                    using (var db = new PumpContext())
                    {
                        int dataId = Convert.ToInt32(dgOperating.CurrentRow.Cells["DataId"].Value);
                        var ett = db.OperatingData.Where(p => p.IsDelete == false && p.DataId == dataId).Select(p => p.ToViewDto()).FirstOrDefault();
                        if (ett != null)
                        {
                            _dataId = dataId;
                            DeleteBtn.Enabled = true;
                            UpdateBtn.Enabled = true;
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

                    LoadOperations();
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
            LoadOperations();
        }

    }
}
