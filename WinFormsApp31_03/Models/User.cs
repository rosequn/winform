using System;
using System.Collections.Generic;

namespace WinFormsApp31_03.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public int Role { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? LastLogin { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();

    public virtual ICollection<MaintenanceHistory> MaintenanceHistories { get; set; } = new List<MaintenanceHistory>();

    public virtual ICollection<Pump> PumpCreatedByNavigations { get; set; } = new List<Pump>();

    public virtual ICollection<Pump> PumpModifiedByNavigations { get; set; } = new List<Pump>();

    public virtual ICollection<PumpStation> PumpStationCreatedByNavigations { get; set; } = new List<PumpStation>();

    public virtual ICollection<PumpStation> PumpStationModifiedByNavigations { get; set; } = new List<PumpStation>();
}
