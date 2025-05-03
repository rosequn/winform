namespace WinFormsApp31_03;

using Enums;
using Models;

public partial class StationUpdatePage : Form
{
    private readonly int? _stationId = null;
    public event EventHandler UpdateStationCompeleted;

    /// <summary>
    /// Initialize
    /// </summary>
    public StationUpdatePage(int? stationId)
    {
        InitializeComponent();
        _stationId = stationId;
        ResetBtn.Enabled = false;
        LoadStationStatus();
        LoadStations();
    }

    private void LoadStationStatus()
    {
        var list = EnumHelper.GetEnumListWithDescriptions<StationStatus>();
        cbStatus.DataSource = list;
        cbStatus.DisplayMember = "Value";
        cbStatus.ValueMember = "Key";
    }

    private void LoadStations()
    {
        if (_stationId != null)
        {
            using (var db = new PumpContext())
            {
                var ett = db.PumpStations.Where(p => p.IsDelete == false && p.StationId == _stationId).Select(p => p.ToViewDto()).FirstOrDefault();
                SetFormValue(ett.StationName, ett.Location, ett.Description, ett.Status);
            }
        }
        else
        {
            MessageBox.Show("Không tìm thấy máy bơm này", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Nút lưu
    private void SaveBtn_Click(object sender, EventArgs e)
    {
        try
        {
            int status = Convert.ToInt32(cbStatus.SelectedValue);
            string stationName = txtName.Text.Trim();
            string location = txtLocation.Text.Trim();
            string description = txtDescription.Text.Trim();
            if (!string.IsNullOrEmpty(stationName) && !string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Thông tin cập nhật không được bỏ trống", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            using (var db = new PumpContext())
            {
                var query = db.PumpStations.Where(p => p.StationId != _stationId && p.IsDelete != false);
                var hasStationNamw = db.PumpStations.FirstOrDefault(p => p.StationName == stationName && p.StationId != _stationId);

                var ett = db.PumpStations.Where(p => p.IsDelete == false && p.StationId == _stationId).FirstOrDefault();
                ett.Update(stationName, location, description, status, Properties.Settings.Default.UserId);
                db.SaveChanges();
                UpdateStationCompeleted?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Cập nhật trạm bơm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    /// </summary>
    /// SetFormValue
    /// </summary>
    /// <param name="name"></param>
    /// <param name="location"></param>
    /// <param name="description"></param>
    private void SetFormValue(string? name, string? location, string? description, int? status)
    {
        txtName.Text = name;
        txtLocation.Text = description;
        txtDescription.Text = description;
        cbStatus.SelectedIndex = status ?? 0;
    }

    private void Clear()
    {
        SetFormValue(string.Empty, string.Empty, string.Empty, null);
        ResetBtn.Enabled = false;
    }

    // Điều kiện bật tắt nút reset
    private void CheckEnableReset(object sender, EventArgs e)
    {
        ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtName.Text.Trim()) ||
                           !string.IsNullOrWhiteSpace(txtLocation.Text.Trim()) ||
                           !string.IsNullOrWhiteSpace(txtDescription.Text.Trim());
    }

}
