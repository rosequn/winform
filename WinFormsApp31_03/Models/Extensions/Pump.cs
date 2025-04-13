using System.Text.Json.Serialization;

namespace WinFormsApp31_03.Models;

using Enums;

partial class Pump
{
    public Pump() { }

    /// <summary>
    /// Create
    /// </summary>
    /// <param name="name"></param>
    /// <param name="type"></param>
    /// <param name="capacity"></param>
    /// <param name="manufacturer"></param>
    /// <param name="serialNumber"></param>
    /// <param name="description"></param>
    /// <param name="expireDate"></param>
    /// <param name="stationId"></param>
    /// <param name="createdBy"></param>
    /// <returns></returns>
    public static Pump Create(string? name, int type, float capacity, string? manufacturer, string? serialNumber, string? description, DateTime? expireDate, int stationId, int createdBy)
    {
        var res = new Pump
        {
            PumpName = name + "",
            PumpType = type,
            Capacity = capacity,
            Manufacturer = manufacturer,
            SerialNumber = serialNumber,
            Description = description + "",
            WarrantyExpireDate = expireDate,
            StationId = stationId,

            CreatedBy = createdBy,
            CreatedOn = DateTime.Now,
        };

        return res;
    }

    /// <summary>
    /// Update
    /// </summary>
    /// <param name="name"></param>
    /// <param name="type"></param>
    /// <param name="capacity"></param>
    /// <param name="manufacturer"></param>
    /// <param name="serialNumber"></param>
    /// <param name="description"></param>
    /// <param name="expireDate"></param>
    /// <param name="status"></param>
    /// <param name="stationId"></param>
    /// <param name="modifiedBy"></param>
    public void Update(string? name, int type, float capacity, string? manufacturer, string? serialNumber, string? description, DateTime? expireDate, int status, int stationId, int modifiedBy)
    {
        PumpName = name + "";
        PumpType = type;
        Capacity = capacity;
        Manufacturer = manufacturer;
        SerialNumber = serialNumber;
        Description = description + "";
        WarrantyExpireDate = expireDate;
        Status = status;
        StationId = stationId;

        ModifiedBy = modifiedBy;
        ModifiedOn = DateTime.Now;
    }

    /// <summary>
    /// Delete
    /// </summary>
    /// <param name="modifiedBy"></param>
    public void Delete(int modifiedBy)
    {
        IsDelete = true;

        ModifiedBy = modifiedBy;
        ModifiedOn = DateTime.UtcNow;
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
            PumpId = PumpId,
            StationId = StationId,
            PumpName = PumpName,
            PumpType = PumpType,
            Capacity = Capacity,
            SerialNumber = SerialNumber,
            WarrantyExpireDate = WarrantyExpireDate,
            Manufacturer = Manufacturer,
            Description = Description,
            Status = Status,
            CreatedBy = CreatedBy,
            CreatedOn = CreatedOn,
            ModifiedOn = ModifiedOn,
            ModifiedBy = ModifiedBy
        };
    }


    public SearchCbDto ToSearchCbDto()
    {
        var res = new SearchCbDto();

        res.PumpId = PumpId;
        res.PumpName = PumpName;

        return res;
    }


    /// <summary>
    /// BaseDto
    /// </summary>
    public class BaseDto
    {
        #region -- Properties --

        /// <summary>
        /// PumpId
        /// </summary>
        public int PumpId { get; set; }

        /// <summary>
        /// StationId
        /// </summary>
        public int? StationId { get; set; }

        /// <summary>
        /// PumpName
        /// </summary>
        public string? PumpName { get; set; }

        /// <summary>
        /// PumpType
        /// </summary>
        public int? PumpType { get; set; }

        /// <summary>
        /// Capacity
        /// </summary>
        public double? Capacity { get; set; }

        /// <summary>
        /// Manufacturer
        /// </summary>
        public string? Manufacturer { get; set; }

        /// <summary>
        /// SerialNumber
        /// </summary>
        public string? SerialNumber { get; set; }

        /// <summary>
        /// WarrantyExpireDate
        /// </summary>
        public DateTime? WarrantyExpireDate { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// CreatedBy
        /// </summary>
        public int? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// ModifiedBy
        /// </summary>
        public int? ModifiedBy { get; set; }

        /// <summary>
        /// ModifiedOn
        /// </summary>
        public DateTime? ModifiedOn { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonIgnore]
        public int Status { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonIgnore]
        public string StatusName => ((StationStatus)Status).ToString();

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

    public class SearchCbDto
    {
        /// <summary>
        /// PumpId
        /// </summary>
        public int PumpId { get; set; }

        /// <summary>
        /// PumpName
        /// </summary>
        public string? PumpName { get; set; }
    }
}

