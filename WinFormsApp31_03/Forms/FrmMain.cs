using System.Runtime.InteropServices;
using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Public;

namespace WinFormsApp31_03.Forms;

public partial class FrmMain : Form
{
    private Button currentButton;
    private Random random;
    private int tempIndex;
    private Form activeForm;

    public FrmMain()
    {
        InitializeComponent();
        random = new Random();
        btnCloseChildForm.Visible = false;
        lblUsername.Text = Properties.Settings.Default.Username;
        HideHeader(false);
        if (Properties.Settings.Default.Role != (int)UserRole.Admin)
        {
            btnUser.Visible = false;
        }
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    public void HideHeader(bool hide)
    {
        if (hide == true)
        {
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            logo.Hide();
            lblTitle.Show();
        }
        else
        {
            OpenChildForm(new HomePage(), null);
            lbl1.Show();
            lbl2.Show();
            lbl3.Show();
            logo.Show();
            lblTitle.Hide();
        }

    }
    //Methods
    private Color SelectThemeColor()
    {
        int index = random.Next(ThemeColor.ColorList.Count);
        while (tempIndex == index)
        {
            index = random.Next(ThemeColor.ColorList.Count);
        }
        tempIndex = index;
        string color = ThemeColor.ColorList[index];
        return ColorTranslator.FromHtml(color);
    }
    private void ActivateButton(object btnSender)
    {
        if (btnSender != null)
        {
            if (currentButton != (Button)btnSender)
            {
                DisableButton();
                Color color = SelectThemeColor();
                currentButton = (Button)btnSender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panelTitleBar.BackColor = color;
                panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                ThemeColor.PrimaryColor = color;
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                btnCloseChildForm.Visible = true;
            }
        }
    }
    private void DisableButton()
    {
        foreach (Control previousBtn in panelMenu.Controls)
        {
            if (previousBtn.GetType() == typeof(Button))
            {
                previousBtn.BackColor = Color.SteelBlue;
                previousBtn.ForeColor = Color.Gainsboro;
                previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
    }

    private void OpenChildForm(Form childForm, object btnSender)
    {
        if (activeForm != null)
            activeForm.Close();

        ActivateButton(btnSender);
        HideHeader(true);
        activeForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        childForm.Margin = new Padding(0);
        childForm.Padding = new Padding(0);

        panelDesktop.SuspendLayout();
        panelDesktop.Controls.Clear();
        panelDesktop.Controls.Add(childForm);
        panelDesktop.Tag = childForm;
        panelDesktop.ResumeLayout(true);

        childForm.BringToFront();
        childForm.Show();
        childForm.Refresh();
        childForm.PerformLayout();

        lblTitle.Text = childForm.Text;
    }

    private void StationBtn_Click(object sender, EventArgs e)
    {
        OpenChildForm(new StationPage(), sender);
    }
    private void PumpBtn_Click(object sender, EventArgs e)
    {
        OpenChildForm(new PumpPage(), sender);
    }
    private void OperatingBtn_Click(object sender, EventArgs e)
    {
        OpenChildForm(new OperatingPage(), sender);
    }
    private void MaintainBtn_Click(object sender, EventArgs e)
    {
        OpenChildForm(new MaintainPage(), sender);
    }
    private void AlertBtn_Click(object sender, EventArgs e)
    {
        OpenChildForm(new AlertPage(), sender);
    }
    private void UserBtn_Click(object sender, EventArgs e)
    {
        OpenChildForm(new UserPage(), sender);
    }

    private void LogoutBtn_Click(Object sender, EventArgs e)
    {
        LoginPage loginPage = new LoginPage();
        loginPage.Show();
        this.Close();
    }

    private void btnCloseChildForm_Click(object sender, EventArgs e)
    {
        if (activeForm != null)
            activeForm.Close();
        HideHeader(false);
        Reset();
    }
    private void Reset()
    {
        DisableButton();
        lblTitle.Text = "HOME";
        panelTitleBar.BackColor = Color.Navy;
        panelLogo.BackColor = Color.Navy;
        currentButton = null;
        btnCloseChildForm.Visible = false;
    }
    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }
}

