using System.Data.SqlClient;

namespace WinFormsApp31_03
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=HAN_TRAN\\WINCCPLUSMIG2014;Database=CSDL_APP;Integrated Security=True;";

        public Form2()
        {
            InitializeComponent();

            // Assign button click events
            QuayLai.Click += Button1_Click;  // Back to Form1
            XacThuc.Click += Button2_Click;  // Login authentication
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string username = TenDangNhap.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;

            string query = @"
                SELECT COUNT(*) FROM Users 
                WHERE Username = @Username 
                AND Password = HASHBYTES('SHA2_256', @Password)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();
                        isAuthenticated = count > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Lỗi SQL: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return isAuthenticated;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
