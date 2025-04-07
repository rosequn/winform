using System;
using System.Collections.Generic;

namespace WinFormsApp31_03.Models;

public partial class Alert
{
    public int AlertId { get; set; }

    public int? PumpId { get; set; }

    public int AlertType { get; set; }

    public string AlertMessage { get; set; } = null!;

    public DateTime AlertTime { get; set; }

    public DateTime? ResolvedTime { get; set; }

    public int Status { get; set; }

    public bool IsDelete { get; set; }

    public int? ResolvedBy { get; set; }

    public virtual Pump? Pump { get; set; }

    public virtual User? ResolvedByNavigation { get; set; }
}
