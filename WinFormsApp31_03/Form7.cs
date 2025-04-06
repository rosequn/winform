namespace WinFormsApp31_03
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        //Xem lưu lượng
        private void FlowRateBtn_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        // Xem áp suất
        private void PressureBtn_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        // Xem công suất
        private void PowerConsumptionBtn_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        // Xem nhiệt độ
        private void TemperatureBtn_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }
    }
}
