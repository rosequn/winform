using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp31_03
{
    public partial class Form6 : Form
    {
        // Chuỗi kết nối SQL Server
        private string connectionString = "Server=HAN_TRAN\\WINCCPLUSMIG2014;Database=CSDL_APP;Integrated Security=True;";

        public Form6()
        {
            InitializeComponent();
            button1.Click += Button1_Click; // Gán sự kiện Click cho nút "Tìm kiếm"
            button2.Click += Button2_Click; // Gán sự kiện Click cho nút "Xóa"
            button3.Click += Button3_Click; // Gán sự kiện Click cho nút "Quay lại"
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();  // Ẩn Form6 (tùy chọn)
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


        // Hàm xóa trạm bơm dựa trên station_id
        private bool XoaTramBom(int stationId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Station WHERE station_id = @StationId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StationId", stationId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu có dữ liệu bị xóa
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa trạm bơm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra ID nhập vào có hợp lệ không
            if (!int.TryParse(textBoxID.Text.Trim(), out int stationId))
            {
                MessageBox.Show("Vui lòng nhập ID hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận trước khi xóa
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa trạm bơm có ID {stationId} không?",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool ketQua = XoaTramBom(stationId);
                if (ketQua)
                {
                    MessageBox.Show("Xóa trạm bơm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
