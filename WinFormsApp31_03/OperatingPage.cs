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

        /// <summary>
        /// Initialize
        /// </summary>
        public OperatingPage()
        {
            InitializeComponent();
            //_userId = userId;
            _userRole = UserRole.Admin;
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
            LoadOperations();
            LoadStation();
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
                var query = db.OperatingData.Where(p => p.IsDelete == false);
                if (_stationId != null)
                {
                    query = query.Where(p => p.Pump.StationId == _stationId);
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
            OperatingCreatePage createPage = new OperatingCreatePage();
            createPage.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (_dataId != null)
            {
                OperatingUpdatePage updatePage = new OperatingUpdatePage(_dataId);
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
    }
}
