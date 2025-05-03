using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    public partial class RegisterPage : Form
    {
        /// <summary>
        /// Initialize
        /// </summary>
        public RegisterPage()
        {
            InitializeComponent();
        }

        public void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string rePassword = txtRePassword.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(rePassword) && !string.IsNullOrEmpty(fullName))
            {
                using (var db = new PumpContext())
                {
                    var ett = db.Users.FirstOrDefault(p => p.Username == username);
                    if (password != rePassword)
                    {
                        MessageBox.Show("Mật khẩu không khớp");
                        return;
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
                        MessageBox.Show("Đăng ký tài khoản thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.SaveChanges();
                        LoadLoginPage();
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng ký không được để trống ");
            }
        }

        public void BackBtn_Click(object sender, EventArgs e)
        {
            LoadLoginPage();
        }

        public void LoadLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }
}
