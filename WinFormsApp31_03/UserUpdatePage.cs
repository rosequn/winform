namespace WinFormsApp31_03;

using Enums;
using Models;

public partial class UserUpdatePage : Form
{
    private readonly int? _userId = null;

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
                var hasUserName = db.Users.FirstOrDefault(p => p.Username == username && p.UserId != _userId);
                var hasPhoneNumber = db.Users.FirstOrDefault(p => p.PhoneNumber == phoneNumber && p.UserId != _userId);

                var ett = db.Users.Where(p => p.IsDelete == false && p.UserId == _userId).FirstOrDefault();
                ett.Update(username, phoneNumber, userRole, fullName, 1);
                db.SaveChanges();
                MessageBox.Show("Cập nhật người dùng thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoToPumpPage();
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
        GoToPumpPage();
    }

    private void GoToPumpPage()
    {
        UserPage userPage = new UserPage();
        userPage.Show();
        this.Hide();
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
