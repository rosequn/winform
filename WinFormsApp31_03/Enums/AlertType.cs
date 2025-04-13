using System.ComponentModel;

namespace WinFormsApp31_03.Enums;

enum AlertType
{
    /// <summary>
    /// Critical
    /// </summary>
    [Description("Khẩn cấp")]
    Critical = 0,

    /// <summary>
    /// Warning
    /// </summary>
    [Description("Cảnh báo")]
    Warning = 1,

    /// <summary>
    /// Info
    /// </summary>
    [Description("Thông tin")]
    Info = 2,
}

