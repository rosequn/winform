using WinFormsApp31_03.Models;

namespace WinFormsApp31_03
{
    public partial class UserPage : Form
    {
        private int? _userId = null;
        private string? _keyword = null;

        /// <summary>
        /// Initialize
        /// </summary>
        public UserPage()
        {
            InitializeComponent();
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
            LoadUsers();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadUsers();
            _userId = null;
            _keyword = null;
        }

        // Load data
        private void LoadUsers()
        {
            dgUser.AutoGenerateColumns = false;
            using (var db = new PumpContext())
            {
                var query = db.Users.Where(p => p.IsDelete == false);
                if (_keyword != null)
                {
                    query = query.Where(u => u.Username.ToLower().Contains(_keyword) || u.Username.ToLower().Contains(_keyword));
                }
                var ett = query.Select(p => p.ToSearchDto()).ToList();
                dgUser.DataSource = ett;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa máy bơm này không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.Users.FirstOrDefault(p => p.UserId == _userId && p.IsDelete == false);
                    if (ett != null)
                    {
                        ett.Delete(1);
                        db.SaveChanges();
                        MessageBox.Show("Xóa máy bơm thành công");
                        LoadUsers();
                        _userId = null;
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
            UserCreatePage createPage = new UserCreatePage();
            createPage.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (_userId != null)
            {
                UserUpdatePage updatePage = new UserUpdatePage(_userId);
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
                if (dgUser.CurrentRow.Index != -1)
                {
                    dgUser.AutoGenerateColumns = false;
                    using (var db = new PumpContext())
                    {
                        int userId = Convert.ToInt32(dgUser.CurrentRow.Cells["UserId"].Value);
                        var ett = db.Users.Where(p => p.IsDelete == false && p.UserId == userId).Select(p => p.ToViewDto()).FirstOrDefault();
                        if (ett != null)
                        {
                            _userId = userId;
                            DeleteBtn.Enabled = true;
                            UpdateBtn.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy người dùng này này", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Search(object sender, EventArgs e)
        {
            _keyword = txtSearch.Text.Trim().ToLower();
            LoadUsers();
        }
    }
}
