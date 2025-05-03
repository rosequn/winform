namespace WinFormsApp31_03.Models;

public partial class MaintenanceHistory
{
    public int MaintenanceId { get; set; }

    public int? PumpId { get; set; }

    public int MaintenanceType { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Description { get; set; }

    public int Status { get; set; }

    public int? PerformedBy { get; set; }

    public bool IsDelete { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual User? PerformedByNavigation { get; set; }

    public virtual Pump? Pump { get; set; }
}
