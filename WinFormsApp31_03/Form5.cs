using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp31_03
{
    public partial class Form5 : Form
    {
        // Chuỗi kết nối SQL Server
        private string connectionString = "Server=HAN_TRAN\\WINCCPLUSMIG2014;Database=CSDL_APP;Integrated Security=True;";

        // Biến lưu ID trạm bơm
        private int selectedStationId = -1;

        public Form5()
        {
            InitializeComponent();
            button1.Click += Button1_Click; // Gán sự kiện Click cho nút "Tìm kiếm"
            button2.Click += Button2_Click; // Gán sự kiện Click cho nút "Cập nhật"
            button3.Click += Button3_Click; // Gán sự kiện Click cho nút "Quay lại"
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();  // Ẩn Form5 (tùy chọn)
        }

        // Tìm kiếm dữ liệu theo tên
        private void Button1_Click(object sender, EventArgs e)
        {
            string searchName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Vui lòng nhập tên trạm bơm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Station WHERE name LIKE @name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + searchName + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.DataSource = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm sửa thông tin trạm bơm (ID không thay đổi)
        private bool SuaTramBom(int id, string tenTram, string viTri, string moTa)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Station SET name = @TenTram, location = @ViTri, description = @MoTa WHERE station_id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@TenTram", tenTram);
                        cmd.Parameters.AddWithValue("@ViTri", viTri);
                        cmd.Parameters.AddWithValue("@MoTa", moTa);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // Sự kiện nhấn nút "Cập Nhật" để lưu dữ liệu đã chỉnh sửa
        private void Button2_Click(object sender, EventArgs e)
        {
            // Lấy ID từ TextBox (hoặc selectedStationId nếu không nhập ID)
            if (!int.TryParse(textBoxID.Text.Trim(), out int idTram))
            {
                MessageBox.Show("Vui lòng nhập ID hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBoxName.Text.Trim();
            string location = textBoxLocation.Text.Trim();
            string description = textBoxDescription.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi hàm sửa dữ liệu
            bool ketQua = SuaTramBom(idTram, name, location, description);
            if (ketQua)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LoadData(); // Làm mới danh sách sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
