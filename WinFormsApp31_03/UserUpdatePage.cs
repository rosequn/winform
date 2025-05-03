namespace WinFormsApp31_03;

using Enums;
using Models;

public partial class UserUpdatePage : Form
{
    private readonly int? _userId = null;
    public event EventHandler UpdateUserCompleted;

    /// <summary>
    /// Initialize
    /// </summary>
    public UserUpdatePage(int? userId)
    {
        InitializeComponent();
        _userId = userId;
        ResetBtn.Enabled = false;
        LoadUserRole();
        LoadUsers();
    }

    private void LoadUserRole()
    {
        var list = EnumHelper.GetEnumListWithDescriptions<UserRole>();
        cbUserRole.DataSource = list;
        cbUserRole.DisplayMember = "Value";
        cbUserRole.ValueMember = "Key";
    }

    private void LoadUsers()
    {
        if (_userId != null)
        {
            using (var db = new PumpContext())
            {
                var ett = db.Users.Where(p => p.IsDelete == false && p.UserId == _userId).Select(p => p.ToViewDto()).FirstOrDefault();
                SetFormValue(ett);
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
            int userRole = Convert.ToInt32(cbUserRole.SelectedValue);
            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(fullName) && string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Thông tin cập nhật không được bỏ trống", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            using (var db = new PumpContext())
            {
                var query = db.Users.Where(p => p.UserId != _userId && p.IsDelete != false);
                var existUserName = db.Users.FirstOrDefault(p => p.Username == username && p.UserId != _userId);
                var existPhoneNumber = db.Users.FirstOrDefault(p => p.PhoneNumber == phoneNumber && p.UserId != _userId);

                if (existPhoneNumber != null)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng vui lòng sử dụng một số điện thoại khác");
                }

                if (existUserName != null)
                {
                    MessageBox.Show("Username đã tồn tại vui lòng chọn một username khác");
                }

                var ett = db.Users.Where(p => p.IsDelete == false && p.UserId == _userId).FirstOrDefault();
                ett.Update(username, phoneNumber, userRole, fullName, Properties.Settings.Default.UserId);
                db.SaveChanges();
                UpdateUserCompleted?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Cập nhật người dùng thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    /// <summary>
    /// SetFormValue
    /// </summary>
    /// <param name="info"></param>
    private void SetFormValue(User.ViewDto? info)
    {
        txtUsername.Text = info?.Username;
        txtPhoneNumber.Text = info?.PhoneNumber;
        txtFullName.Text = info?.FullName;
        cbUserRole.SelectedIndex = info?.Role ?? 0;
    }
    private void Clear()
    {

        SetFormValue(null);
        ResetBtn.Enabled = false;
    }

    // Điều kiện bật tắt nút reset
    private void CheckEnableReset(object sender, EventArgs e)
    {
        ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtUsername.Text.Trim()) ||
                           !string.IsNullOrWhiteSpace(txtPhoneNumber.Text.Trim()) ||
                           !string.IsNullOrWhiteSpace(txtFullName.Text.Trim());
    }

}
