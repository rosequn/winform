namespace WinFormsApp31_03
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        // Quay lại
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
    }
}
