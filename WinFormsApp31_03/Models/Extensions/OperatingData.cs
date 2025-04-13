namespace WinFormsApp31_03.Models;
partial class OperatingData
{
    public OperatingData() { }

    /// <summary>
    /// Create
    /// </summary>
    /// <param name="pumpId"></param>
    /// <param name="recordTime"></param>
    /// <param name="flowRate"></param>
    /// <param name="pressure"></param>
    /// <param name="powerConsumption"></param>
    /// <param name="temperature"></param>
    /// <param name="runningHours"></param>
    /// <param name="efficiency"></param>
    /// <returns></returns>
    public static OperatingData Create(int pumpId, DateTime recordTime, double flowRate, double pressure, double powerConsumption, double temperature, double runningHours, double efficiency)
    {
        var res = new OperatingData
        {
            PumpId = pumpId,
            RecordTime = recordTime,
            FlowRate = flowRate,
            Pressure = pressure,
            PowerConsumption = powerConsumption,
            Temperature = temperature,
            RunningHours = runningHours,
            Efficiency = efficiency

        };

        return res;
    }

    /// <summary>
    /// Update
    /// </summary>
    /// <param name="pumpId"></param>
    /// <param name="recordTime"></param>
    /// <param name="flowRate"></param>
    /// <param name="pressure"></param>
    /// <param name="powerConsumption"></param>
    /// <param name="temperature"></param>
    /// <param name="runningHours"></param>
    /// <param name="efficiency"></param>
    public void Update(int pumpId, DateTime recordTime, double flowRate, double pressure, double powerConsumption, double temperature, double runningHours, double efficiency)
    {
        PumpId = pumpId;
        RecordTime = recordTime;
        FlowRate = flowRate;
        Pressure = pressure;
        PowerConsumption = powerConsumption;
        Temperature = temperature;
        RunningHours = runningHours;
        Efficiency = efficiency;

        ModifiedOn = DateTime.Now;
    }

    /// <summary>
    /// Delete
    /// </summary>
    /// <param name="modifiedBy"></param>
    public void Delete(int modifiedBy)
    {
        IsDelete = true;

        ModifiedOn = DateTime.Now;
    }

    public SearchDto ToSearchDto()
    {
        var res = ToBaseDto<SearchDto>();
        return res;
    }


    public ViewDto ToViewDto()
    {
        var res = ToBaseDto<ViewDto>();
        return res;
    }

    /// <summary>
    /// Convert to data transfer object
    /// </summary>
    /// <returns>Return the DTO</returns>
    public T ToBaseDto<T>() where T : BaseDto, new()
    {
        return new T
        {
            DataId = DataId,
            PumpId = PumpId,
            RecordTime = RecordTime,
            FlowRate = FlowRate,
            Pressure = Pressure,
            PowerConsumption = PowerConsumption,
            Temperature = Temperature,
            RunningHours = RunningHours,
            Efficiency = Efficiency,
        };
    }

    /// <summary>
    /// BaseDto
    /// </summary>
    public class BaseDto
    {
        #region -- Properties --

        /// <summary>
        /// DataId
        /// </summary>
        public int DataId { get; set; }

        /// <summary>
        /// PumpId
        /// </summary>
        public int? PumpId { get; set; }

        /// <summary>
        /// RecordTime
        /// </summary>
        public DateTime? RecordTime { get; set; }

        /// <summary>
        /// FlowRate
        /// </summary>
        public double? FlowRate { get; set; }

        /// <summary>
        /// Pressure
        /// </summary>
        public double? Pressure { get; set; }

        /// <summary>
        /// PowerConsumption
        /// </summary>
        public double? PowerConsumption { get; set; }

        /// <summary>
        /// Temperature
        /// </summary>
        public double? Temperature { get; set; }

        /// <summary>
        /// RunningHours
        /// </summary>
        public double? RunningHours { get; set; }

        /// <summary>
        /// Efficiency
        /// </summary>
        public double? Efficiency { get; set; }

        /// <summary>
        /// CreatedOn
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// ModifiedOn
        /// </summary>
        public DateTime? ModifiedOn { get; set; }

        #endregion
    }

    /// <summary>
    /// ViewDto
    /// </summary>
    public class ViewDto : BaseDto
    {
    }

    /// <summary>
    /// SearchDto
    /// </summary>
    public class SearchDto : BaseDto
    {
    }
}

