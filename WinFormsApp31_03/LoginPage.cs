using Microsoft.EntityFrameworkCore;
using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    public partial class LoginPage : Form
    {
        /// <summary>
        /// Initialize
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
            LoadUser();
        }


        public void LoadUser()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkRememberMe.Checked = Properties.Settings.Default.RememberMe;
            }
        }
        public void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (ValidateLogin(username, password))
            {
                SaveInformation(username, password);
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                PumpPage form3 = new PumpPage();
                form3.Show();

            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
            }
        }

        public async void SaveInformation(string userName, string password)
        {
            var db = new PumpContext();
            var ett = await db.Users.Where(u => u.Username == userName).FirstOrDefaultAsync();

            SessionManager.Username = ett.Username;
            SessionManager.FullName = ett.FullName;
            SessionManager.Role = ett.Role;
            SessionManager.Password = password;

            // Nếu muốn ghi nhớ cho lần sau
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.Username = ett.Username;
                Properties.Settings.Default.FullName = ett.FullName;
                Properties.Settings.Default.Role = ett.Role;
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            string hashedPassword = PasswordHash.HashPassword(password);

            using (var db = new PumpContext())
            {
                var ett = db.Users.FirstOrDefault(p => p.Username == username && (p.Password == hashedPassword || p.Password == password) && p.IsDelete == false);
                return ett != null;
            }
        }
    }
}
