using WinFormsApp31_03.Enums;

namespace WinFormsApp31_03.Models;
partial class MaintenanceHistory
{
    public MaintenanceHistory() { }

    /// <summary>
    /// Create
    /// </summary>
    /// <param name="pumpId"></param>
    /// <param name="maintainType"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="description"></param>
    /// <returns></returns>
    public static MaintenanceHistory Create(int pumpId, int maintainType, DateTime startDate, DateTime? endDate, string? description)
    {
        var res = new MaintenanceHistory
        {
            PumpId = pumpId,
            MaintenanceType = maintainType,
            StartDate = startDate,
            EndDate = endDate,
            Description = description,
            Status = startDate >= DateTime.Now ? (int)MaintainStatus.Scheduled : (int)MaintainStatus.InProgress,
        };

        return res;
    }

    /// <summary>
    /// Update
    /// </summary>
    /// <param name="pumpId"></param>
    /// <param name="maintainType"></param>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    /// <param name="description"></param>
    /// <param name="status"></param>
    /// <param name="modifiedBy"></param>
    public void Update(int pumpId, int maintainType, DateTime startDate, DateTime? endDate, string? description, int modifiedBy)
    {
        PumpId = pumpId;
        MaintenanceType = maintainType;
        StartDate = startDate;
        EndDate = endDate;
        Description = description;

        PerformedBy = modifiedBy;
    }

    /// <summary>
    /// UpdateStatus
    /// </summary>
    /// <param name="status"></param>
    /// <param name="modifiedBy"></param>
    public void UpdateStatus(int status, int? modifiedBy)
    {
        Status = status;

        PerformedBy = modifiedBy;
    }

    /// <summary>
    /// Delete
    /// </summary>
    /// <param name="modifiedBy"></param>
    public void Delete(int modifiedBy)
    {
        IsDelete = true;

        PerformedBy = modifiedBy;
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
            MaintenanceId = MaintenanceId,
            Description = Description,
            StartDate = StartDate,
            EndDate = EndDate,
            PerformedBy = PerformedBy,
            Status = Status,
            Type = MaintenanceType,
            PumpName = Pump?.PumpName,
            PerformedName = PerformedByNavigation?.FullName ?? string.Empty,
        };
    }

    /// <summary>
    /// BaseDto
    /// </summary>
    public class BaseDto
    {
        #region -- Properties --

        /// <summary>
        /// MaintenanceId
        /// </summary>
        public int? MaintenanceId { get; set; }

        /// <summary>
        /// Descriptions
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// StartDate
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// MaintenanceType
        /// </summary>
        public int? Type { get; set; }

        /// <summary>
        /// MaintenanceTypeName
        /// </summary>
        public string TypeName
        {
            get
            {
                return EnumHelper.GetDescription((MaintainType)Type.Value);
            }
        }

        /// <summary>
        /// MaintenanceStatus
        /// </summary>
        public int? Status { get; set; }


        /// <summary>
        /// MaintenanceStatusName
        /// </summary>
        public string StatusName
        {
            get
            {
                return EnumHelper.GetDescription((MaintainStatus)Status.Value);
            }
        }

        /// <summary>
        /// PumpId
        /// </summary>
        public int? PumpId { get; set; }

        /// <summary>
        /// PumpName
        /// </summary>
        public string? PumpName { get; set; }


        /// <summary>
        /// CreatedOn
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// PerformedBy
        /// </summary>
        public int? PerformedBy { get; set; }

        /// <summary>
        /// PerformedName
        /// </summary>
        public string? PerformedName { get; set; }

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

