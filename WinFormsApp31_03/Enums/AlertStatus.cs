﻿using System.ComponentModel;

namespace WinFormsApp31_03.Enums;

enum AlertStatus
{
    /// <summary>
    /// Active
    /// </summary>
    [Description("Chưa xử lý")]
    Active = 0,

    /// <summary>
    /// Ignored
    /// </summary>
    [Description("Đã bỏ qua")]
    Ignored = 1,

    /// <summary>
    /// Resolved
    /// </summary>
    [Description("Đã xử lý")]
    Resolved = 2,
}
