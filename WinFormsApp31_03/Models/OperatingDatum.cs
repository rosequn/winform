using System;
using System.Collections.Generic;

namespace WinFormsApp31_03.Models;

public partial class OperatingDatum
{
    public int DataId { get; set; }

    public int? PumpId { get; set; }

    public DateTime RecordTime { get; set; }

    public double? FlowRate { get; set; }

    public double? Pressure { get; set; }

    public double? PowerConsumption { get; set; }

    public double? Temperature { get; set; }

    public double? RunningHours { get; set; }

    public double? Efficiency { get; set; }

    public virtual Pump? Pump { get; set; }
}
