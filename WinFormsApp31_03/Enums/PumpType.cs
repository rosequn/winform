﻿using System.ComponentModel;

namespace WinFormsApp31_03.Enums;

enum PumpType
{
    /// <summary>
    /// Centrifugal
    /// </summary>
    [Description("Máy bơm ly tâm")]
    Centrifugal = 0,

    /// <summary>
    /// Screw
    /// </summary>
    [Description("Máy bơm trục vít")]
    Screw = 1,

    /// <summary>
    /// Piston
    /// </summary>
    [Description("Máy bơm pittông")]
    Piston = 2,

    /// <summary>
    /// Diaphragm
    /// </summary>
    [Description("Máy bơm màng")]
    Diaphragm = 3
}

