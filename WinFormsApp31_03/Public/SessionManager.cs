namespace WinFormsApp31_03;

public class SessionManager
{
    public static string? Username { get; set; }
    public static string? Password { get; set; }
    public static string? FullName { get; set; }
    public static int? Role { get; set; }
    public static int? UserId { get; set; }

    public static void LoadFromSettings()
    {
        UserId = Properties.Settings.Default.UserId;
        Username = Properties.Settings.Default.Username;
        FullName = Properties.Settings.Default.FullName;
        Password = Properties.Settings.Default.Password;
        Role = Properties.Settings.Default.Role;
    }

    public static void Clear()
    {
        UserId = null;
        Username = null;
        FullName = null;
        Role = null;
    }
}
