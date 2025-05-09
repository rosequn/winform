using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.PumpStation;

namespace WinFormsApp31_03
{
    public partial class PumpPage : Form
    {
        private int? _pumpId = null;
        private int? _stationId = null;
        private string? _keyword = null;

        /// <summary>
        /// Initialize
        /// </summary>
        public PumpPage()
        {
            InitializeComponent();
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
            LoadPumps();
            LoadStation();
            LoadComponents();
        }

        private void LoadComponents()
        {
            DataGridViewStyler.ApplyCustomStyle(dgPump);
            dgPump.RowPrePaint += DataGridViewStyler.RowRepaint;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadPumps();
            _pumpId = null;
            _keyword = null;
            _stationId = null;
        }

        // Load data
        private void LoadPumps()
        {
            dgPump.AutoGenerateColumns = false;
            using (var db = new PumpContext())
            {
                var query = db.Pumps.Where(p => p.IsDelete == false);
                if (_stationId != null)
                {
                    query = query.Where(p => p.StationId == _stationId);
                }
                if (_keyword != null)
                {
                    query = query.Where(u => u.PumpName.ToLower().Contains(_keyword) || u.SerialNumber.ToLower().Contains(_keyword));
                }
                var ett = query.Select(p => p.ToSearchDto()).ToList();
                dgPump.DataSource = ett;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa máy bơm này không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.Pumps.FirstOrDefault(p => p.PumpId == _pumpId && p.IsDelete == false);
                    if (ett != null)
                    {
                        ett.Delete(1);
                        db.SaveChanges();
                        MessageBox.Show("Xóa máy bơm thành công");
                        LoadPumps();
                        _pumpId = null;
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
            PumpCreatePage createPage = new PumpCreatePage();
            createPage.StartPosition = FormStartPosition.CenterScreen;

            createPage.FormClosed += (s, eArgs) =>
            {
                CreateBtn.Enabled = true;
            };

            createPage.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (_pumpId != null)
            {
                UpdateBtn.Enabled = false;
                DeleteBtn.Enabled = false;
                PumpUpdatePage updatePage = new PumpUpdatePage(_pumpId);
                updatePage.StartPosition = FormStartPosition.CenterScreen;
                updatePage.UpdatePumpCompleted += (s, args) =>
                {
                    _pumpId = null;
                    LoadPumps();
                };

                updatePage.FormClosed += (s, eArgs) =>
                {
                    UpdateBtn.Enabled = _pumpId != null;
                    DeleteBtn.Enabled = _pumpId != null;
                };

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
                if (dgPump.CurrentRow.Index != -1)
                {
                    dgPump.CurrentRow.Selected = true;
                    dgPump.Refresh();
                    dgPump.AutoGenerateColumns = false;
                    using (var db = new PumpContext())
                    {
                        int pumpId = Convert.ToInt32(dgPump.CurrentRow.Cells["PumpId"].Value);
                        var ett = db.Pumps.Where(p => p.IsDelete == false && p.PumpId == pumpId).Select(p => p.ToViewDto()).FirstOrDefault();
                        if (ett != null)
                        {
                            _pumpId = pumpId;
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

                    LoadPumps();
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
            LoadPumps();
        }

    }
}
