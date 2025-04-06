namespace WinFormsApp31_03.Models;

public partial class PumpStation
{
    public int StationId { get; set; }

    public string StationName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? Description { get; set; }

    public int Status { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<Pump> Pumps { get; set; } = new List<Pump>();
}
