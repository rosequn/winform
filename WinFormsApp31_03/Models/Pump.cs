using System;
using System.Collections.Generic;

namespace WinFormsApp31_03.Models;

public partial class Pump
{
    public int PumpId { get; set; }

    public int? StationId { get; set; }

    public string PumpName { get; set; } = null!;

    public string PumpCode { get; set; } = null!;

    public int PumpType { get; set; }

    public double? Capacity { get; set; }

    public int Status { get; set; }

    public string? Manufacturer { get; set; }

    public string? Model { get; set; }

    public string? SerialNumber { get; set; }

    public DateOnly? WarrantyExpireDate { get; set; }

    public string? Description { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<MaintenanceHistory> MaintenanceHistories { get; set; } = new List<MaintenanceHistory>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<OperatingDatum> OperatingData { get; set; } = new List<OperatingDatum>();

    public virtual PumpStation? Station { get; set; }
}
