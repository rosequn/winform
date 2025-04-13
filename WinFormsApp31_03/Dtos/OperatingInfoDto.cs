public class OperatingInfoDto
{
    public int DataId { get; set; }
    public int? PumpId { get; set; }
    public DateTime? RecordTime { get; set; }
    public double? FlowRate { get; set; }
    public double? Pressure { get; set; }
    public double? PowerConsumption { get; set; }
    public double? Temperature { get; set; }
    public double? RunningHours { get; set; }
    public double? Efficiency { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }


    public static OperatingInfoDto DefaultInfo()
    {
        return new OperatingInfoDto
        {
            PumpId = null,
            RecordTime = DateTime.Now,
            FlowRate = null,
            Pressure = null,
            PowerConsumption = null,
            Temperature = null,
            RunningHours = null,
            Efficiency = null,
        };
    }

}

