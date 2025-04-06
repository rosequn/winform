namespace WinFormsApp31_03;

using Models;
using System;
using WinFormsApp31_03.Enums;

/// <summary>
/// CreatePumpStation
/// </summary>
public partial class Form4 : Form
{
    private readonly int _userId;
    private readonly UserRole _userRole;
    public Form4(int userId)
    {
        InitializeComponent();
        _userId = userId;
        _userRole = UserRole.Admin;
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
        try
        {

            if (_userRole != UserRole.Admin)
            {
                MessageBox.Show("Bạn không có quyền tạo mới", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (var db = new PumpContext())
            {
                var ett = PumpStation.Create(txtName.Text.Trim(), txtName.Text.Trim(), txtLocation.Text.Trim(), 1);

                db.PumpStations.Add(ett);
                db.SaveChanges();
            }
            MessageBox.Show("Tạo mới trạm bơm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Đặt lại
    private void ResetBtn_Click(object sender, EventArgs e)
    {
        Clear();
    }

    private void Form4_Load(object sender, EventArgs e)
    {
        Clear();
    }
    private void Clear()
    {
        txtName.Text = string.Empty;
        txtLocation.Text = string.Empty;
        txtDescription.Text = string.Empty;
        ResetBtn.Enabled = false;
    }

}

