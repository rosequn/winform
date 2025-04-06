using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp31_03
{
    public partial class Form3 : Form
    {
        // Chuỗi kết nối đến SQL Server
        private string connectionString = "Server=.\\SQLEXPRESS;Database=PumpStationManagement;Trusted_Connection=True;TrustServerCertificate=True;";

        // Biến toàn cục để quản lý phân trang
        private int offset = 10; // Vị trí bắt đầu lấy dữ liệu
        private int totalRows = 5; // Tổng số dòng trong bảng
        private int fetchSize = 1; // Số dòng lấy mỗi lần (mặc định 1 để tránh lỗi)

        public Form3()
        {
            InitializeComponent();
            // Gán sự kiện click cho các nút
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button8.Click += new System.EventHandler(this.LoadNextData);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadInitialData();
        }

        // Hàm lấy tổng số dòng và tải dữ liệu ban đầu
        private void LoadInitialData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Lấy tổng số dòng
                    string countQuery = "SELECT COUNT(*) FROM PumpStations;";
                    using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                    {
                        totalRows = (int)countCmd.ExecuteScalar();
                    }

                    // Tính số dòng cần hiển thị mỗi lần (ít nhất 1 dòng để tránh lỗi)
                    fetchSize = Math.Max(1, (int)Math.Ceiling(totalRows * 0.1));
                    offset = 0; // Bắt đầu từ đầu bảng

                    LoadNextData(null, EventArgs.Empty);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu ban đầu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm lấy dữ liệu tiếp theo khi nhấn button8
        private void LoadNextData(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Truy vấn lấy dữ liệu với phân trang
                    string query = $"SELECT * FROM PumpStations ORDER BY StationID ASC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dtNew = new DataTable();
                        adapter.Fill(dtNew);

                        if (dtNew.Rows.Count > 0)
                        {
                            DataTable dtOld = dataGridView1.DataSource as DataTable;

                            if (dtOld == null)
                            {
                                dataGridView1.DataSource = dtNew;
                            }
                            else
                            {
                                dtOld.Merge(dtNew); // Giữ lại dữ liệu cũ và thêm dữ liệu mới
                                dataGridView1.DataSource = dtOld;
                            }

                            offset += fetchSize; // Cập nhật vị trí lấy dữ liệu tiếp theo
                            fetchSize += 2; // Mỗi lần nhấn sẽ tăng số dòng tải thêm
                        }
                        else
                        {
                            MessageBox.Show("Không còn dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Form4 form4 = new Form4();
            //form4.Show();
            this.Hide();  // Ẩn Form3 (tùy chọn)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();  // Ẩn Form3 (tùy chọn)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();  // Ẩn Form3 (tùy chọn)
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }



        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PumpBtn_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
    }
}
