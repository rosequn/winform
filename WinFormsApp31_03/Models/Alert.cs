namespace WinFormsApp31_03.Models;

public partial class Alert
{
    public int AlertId { get; set; }

    public int? PumpId { get; set; }

    public int AlertType { get; set; }

    public string AlertMessage { get; set; } = null!;

    public int Status { get; set; }

    public bool IsDelete { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual Pump? Pump { get; set; }
}
