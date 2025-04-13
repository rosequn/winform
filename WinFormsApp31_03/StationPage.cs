using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    public partial class StationPage : Form
    {
        private readonly int _userId;
        private readonly UserRole _userRole;
        private int? _stationId = null;

        /// <summary>
        /// Initialize
        /// </summary>
        public StationPage()
        {
            InitializeComponent();
            //_userId = userId;
            _userRole = UserRole.Admin;
            DeleteBtn.Enabled = false;
            ResetBtn.Enabled = false;
            SaveBtn.Text = "Tạo mới";
            Clear();
            LoadPumpStations();
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
                var ett = db.PumpStations.Where(p => p.IsDelete == false).Select(p => p.ToSearchDto()).ToList();
                dgStation.DataSource = ett;
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

                using (var db = new PumpContext())
                {
                    PumpStation ett = new PumpStation();
                    if (_stationId == null)
                    {
                        // Add UserId(Replace 1)
                        ett = PumpStation.Create(txtName.Text.Trim(), txtLocation.Text.Trim(), txtDescription.Text.Trim(), 1);
                        db.PumpStations.Add(ett);
                        MessageBox.Show("Tạo mới trạm bơm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Add Status and UserId(Replace 0,1)
                        ett = db.PumpStations.FirstOrDefault(p => p.StationId == _stationId && p.IsDelete == false);
                        if (ett != null)
                        {
                            ett.Update(txtName.Text.Trim(), txtLocation.Text.Trim(), txtDescription.Text.Trim(), 0, 1);
                            MessageBox.Show("Cập nhật trạm bơm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    db.SaveChanges();
                    LoadPumpStations();
                }

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đặt lại
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Text = "Tạo mới";
            _stationId = null;
            Clear();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa trạm bơm này không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.PumpStations.FirstOrDefault(p => p.StationId == _stationId && p.IsDelete == false);
                    var ettPump = db.Pumps.Where(p => p.StationId == _stationId && p.IsDelete == false).ToList();
                    if (ett != null)
                    {
                        ett.Delete(1);
                        db.SaveChanges();
                        MessageBox.Show("Xóa trạm bơm thành công");
                        LoadPumpStations();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy trạm bơm");
                    }

                    if (ettPump != null)
                    {
                        foreach (var i in ettPump)
                        {
                            i.Delete(1);
                        }
                    }
                }
            }

        }

        // Nút hủy
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Text = "Tạo mới";
            SetFormValue(string.Empty, string.Empty, string.Empty);
            ResetBtn.Enabled = false;
            _stationId = null;
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
                            SetFormValue(ett.StationName, ett.Location, ett.Description);
                            _stationId = stationId;
                            SaveBtn.Text = "Cập nhật";
                            DeleteBtn.Enabled = true;
                            ResetBtn.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy trạm bơm này", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// SetFormValue
        /// </summary>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="description"></param>
        private void SetFormValue(string? name, string? location, string? description)
        {
            txtName.Text = name;
            txtLocation.Text = location;
            txtDescription.Text = description;
        }

        private void Clear()
        {
            SetFormValue(string.Empty, string.Empty, string.Empty);
            ResetBtn.Enabled = false;
        }

        // Điều kiện bật tắt nút reset
        private void CheckEnableReset(object sender, EventArgs e)
        {
            ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtName.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtLocation.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtDescription.Text.Trim());
            DeleteBtn.Enabled = _stationId != null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
