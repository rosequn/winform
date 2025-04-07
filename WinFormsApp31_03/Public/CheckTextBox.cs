namespace WinFormsApp31_03;

public class CheckTextBox
{
    public static void Number_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) &&
            !char.IsDigit(e.KeyChar) &&
            e.KeyChar != '.' &&
            e.KeyChar != ',')
        {
            e.Handled = true;
        }

        TextBox tb = sender as TextBox;
        if ((e.KeyChar == '.' || e.KeyChar == ',') && (tb.Text.Contains('.') || tb.Text.Contains(',')))
        {
            e.Handled = true;
        }
    }
}
