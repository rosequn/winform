using System.ComponentModel;

namespace WinFormsApp31_03.Enums;

enum UserRole
{
    /// <summary>
    /// User
    /// </summary>
    [Description("Người dùng")]
    User = 0,

    /// <summary>
    /// Admin
    /// </summary>
    [Description("Quản trị viên")]
    Admin = 1,
}

