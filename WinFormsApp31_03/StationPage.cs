using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    public partial class StationPage : Form
    {
        private int? _stationId = null;
        private string? _keyword = null;

        /// <summary>
        /// Initialize
        /// </summary>
        public StationPage()
        {
            InitializeComponent();
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
            _keyword = null;
            LoadPumpStations();
            LoadComponents();
        }

        private void LoadComponents()
        {
            DataGridViewStyler.ApplyCustomStyle(dgStation);
            dgStation.RowPrePaint += DataGridViewStyler.RowRepaint;
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadPumpStations();
            _stationId = null;
        }

        // Load data
        private void LoadPumpStations()
        {
            dgStation.AutoGenerateColumns = false;
            using (var db = new PumpContext())
            {
                var query = db.PumpStations.Where(p => p.IsDelete == false);
                if (_keyword != null)
                {
                    query = query.Where(u => u.StationName.ToLower().Contains(_keyword) || u.Location.ToLower().Contains(_keyword));
                }
                var ett = query.Select(p => p.ToSearchDto()).ToList();
                dgStation.DataSource = ett;
            }
        }

        private void dgStation_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgStation.CurrentRow.Index != -1)
                {
                    dgStation.AutoGenerateColumns = false;
                    using (var db = new PumpContext())
                    {
                        int stationId = Convert.ToInt32(dgStation.CurrentRow.Cells["StationId"].Value);
                        var ett = db.PumpStations.Where(p => p.IsDelete == false && p.StationId == stationId).Select(p => p.ToViewDto()).FirstOrDefault();
                        if (ett != null)
                        {
                            _stationId = stationId;
                            CreateBtn.Text = "Cập nhật";
                            DeleteBtn.Enabled = true;
                            UpdateBtn.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy trạm bơm này", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa trạm bơm này không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.PumpStations.FirstOrDefault(p => p.StationId == _stationId && p.IsDelete == false);
                    if (ett != null)
                    {
                        ett.Delete(1);
                        db.SaveChanges();
                        MessageBox.Show("Xóa máy bơm thành công");
                        LoadPumpStations();
                        _stationId = null;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy máy bơm này");
                    }
                }
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateBtn.Enabled = false;
            StationCreatePage createPage = new StationCreatePage();
            createPage.StartPosition = FormStartPosition.CenterScreen;
            createPage.FormClosed += (s, eArgs) =>
            {
                CreateBtn.Enabled = true;
            };

            createPage.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (_stationId != null)
            {
                UpdateBtn.Enabled = false;
                DeleteBtn.Enabled = false;
                StationUpdatePage updatePage = new StationUpdatePage(_stationId);
                updatePage.StartPosition = FormStartPosition.CenterScreen;
                updatePage.UpdateStationCompeleted += (s, args) =>
                {
                    _stationId = null;
                    LoadPumpStations();
                };

                updatePage.FormClosed += (s, eArgs) =>
                {
                    UpdateBtn.Enabled = _stationId != null;
                    DeleteBtn.Enabled = _stationId != null;
                };

                updatePage.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search(object sender, EventArgs e)
        {
            _keyword = txtSearch.Text.Trim().ToLower();
            LoadPumpStations();
        }
    }
}
