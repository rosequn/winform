using WinFormsApp31_03.Enums;

public class PumpInfoDto
{
    public string? PumpName { get; set; }
    public string? Description { get; set; }
    public string? Manufacturer { get; set; }
    public string? SerialNumber { get; set; }
    public double? Capacity { get; set; }
    public int Status { get; set; }
    public int? StationId { get; set; }
    public int Type { get; set; }
    public DateTime? ExpiredDate { get; set; }

    public static PumpInfoDto DefaultInfo()
    {
        return new PumpInfoDto
        {
            PumpName = string.Empty,
            Description = string.Empty,
            Manufacturer = string.Empty,
            Capacity = null,
            SerialNumber = string.Empty,
            Status = (int)PumpStatus.Active,
            StationId = 1,
            Type = (int)PumpType.Centrifugal,
            ExpiredDate = DateTime.Now
        };
    }

}

