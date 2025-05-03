using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    public partial class UserCreatePage : Form
    {
        /// <summary>
        /// Initialize
        /// </summary>
        /// User user(param)
        public UserCreatePage()
        {
            InitializeComponent();
            ResetBtn.Enabled = false;
            LoadUserRole();
            Clear();
        }

        private void LoadUserRole()
        {
            var list = EnumHelper.GetEnumListWithDescriptions<UserRole>();
            cbUserRole.DataSource = list;
            cbUserRole.DisplayMember = "Value";
            cbUserRole.ValueMember = "Key";
        }

        // Nút lưu
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PumpContext())
                {
                    string username = txtUsername.Text.Trim();
                    string fullName = txtFullName.Text.Trim();
                    string phoneNumber = txtPhoneNumber.Text.Trim();
                    string password = "User@123";
                    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(fullName))
                    {
                        var query = db.Users.Where(p => p.IsDelete == false);
                        var ett = query.FirstOrDefault(p => p.Username == username);
                        var existPhoneNumber = query.FirstOrDefault(p => p.PhoneNumber == phoneNumber);

                        if (existPhoneNumber != null)
                        {
                            MessageBox.Show("Số điện thoại đã được sử dụng vui lòng sử dụng một số điện thoại khác");
                        }

                        if (ett != null)
                        {
                            MessageBox.Show("Username đã tồn tại vui lòng chọn một username khác");
                        }
                        else
                        {
                            string hashPassword = PasswordHash.HashPassword(password);
                            ett = User.Create(username, hashPassword, fullName, Properties.Settings.Default.UserId);
                            db.Users.Add(ett);
                            MessageBox.Show("Tạo mới tài khoản thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            db.SaveChanges();
                            ClosePage();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng ký không được để trống ");
                    }
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
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="description"></param>
        private void SetFormValue(string? name, string? fullName, string? phoneNumber)
        {
            txtUsername.Text = name;
            txtFullName.Text = fullName;
            txtPhoneNumber.Text = phoneNumber;
        }

        private void Clear()
        {
            SetFormValue(string.Empty, string.Empty, string.Empty);
            ResetBtn.Enabled = false;
        }

        // Điều kiện bật tắt nút reset
        private void CheckEnableReset(object sender, EventArgs e)
        {
            ResetBtn.Enabled = !string.IsNullOrWhiteSpace(txtUsername.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtFullName.Text.Trim()) ||
                               !string.IsNullOrWhiteSpace(txtPhoneNumber.Text.Trim());
        }
    }
}
