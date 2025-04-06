namespace WinFormsApp31_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DangNhap.Click += DangNhap_Click; // Gán sự kiện cho button1
            DangKy.Click += DangKy_Click; // Gán sự kiện cho button1
        }
        private void DangNhap_Click(object? sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // Mở Form2
            this.Hide();  // Ẩn Form1
        }
        private void DangKy_Click(object? sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); // Mở Form2
            this.Hide();  // Ẩn Form1
                          // MessageBox.Show("Hello World!"); // Hiển thị MessageBox
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
