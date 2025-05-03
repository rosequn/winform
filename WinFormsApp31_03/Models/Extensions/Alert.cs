using WinFormsApp31_03.Enums;

namespace WinFormsApp31_03.Models;
partial class Alert
{
    public Alert() { }

    /// <summary>
    /// Create
    /// </summary>
    /// <param name="pumpId"></param>
    /// <param name="alertType"></param>
    /// <param name="alertMessage"></param>
    /// <param name="createdBy"></param>
    /// <returns></returns>
    public static Alert Create(int pumpId, int alertType, string alertMessage, int? createdBy)
    {
        var res = new Alert
        {
            PumpId = pumpId,
            AlertType = alertType,
            AlertMessage = alertMessage,
            CreatedBy = createdBy,
            CreatedOn = DateTime.Now,
        };

        return res;
    }

    /// <summary>
    /// Update
    /// </summary>
    /// <param name="pumpId"></param>
    /// <param name="alertType"></param>
    /// <param name="alertMessage"></param>
    /// <param name="modifiedBy"></param>
    public void Update(int? pumpId, int alertType, string? alertMessage, int? modifiedBy)
    {
        PumpId = pumpId;
        AlertType = alertType;
        AlertMessage = alertMessage + "";
    }


    /// <summary>
    /// UpdateStatus
    /// </summary>
    /// <param name="status"></param>
    /// <param name="modifiedBy"></param>
    public void UpdateStatus(int status, int? modifiedBy)
    {
        Status = status;

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
            AlertId = AlertId,
            PumpId = PumpId,
            AlertType = AlertType,
            AlertMessage = AlertMessage,
            Status = Status,
            IsDelete = IsDelete,
            PumpName = Pump?.PumpName + "",
            CreatedBy = CreatedBy,
            CreatedOn = CreatedOn,
            ModifiedBy = ModifiedBy,
            ModifiedOn = ModifiedOn,
            ResolvedBy = ModifiedByNavigation?.FullName + ""
        };
    }

    /// <summary>
    /// BaseDto
    /// </summary>
    public class BaseDto
    {
        #region -- Properties --

        /// <summary>
        /// AlertId
        /// </summary>
        public int AlertId { get; set; }

        /// <summary>
        /// PumpId
        /// </summary>
        public int? PumpId { get; set; }

        /// <summary>
        /// PumpName
        /// </summary>
        public string? PumpName { get; set; }

        /// <summary>
        /// AlertType
        /// </summary>
        public int AlertType { get; set; }

        /// <summary>
        /// AlertName
        /// </summary>
        public string AlertName
        {
            get
            {
                return EnumHelper.GetDescription((AlertType)Status);
            }
        }

        /// <summary>
        /// AlertMessage
        /// </summary>
        public string AlertMessage { get; set; } = null!;

        /// <summary>
        /// Status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// StatusName
        /// </summary>
        public string StatusName
        {
            get
            {
                return EnumHelper.GetDescription((AlertStatus)Status);
            }
        }

        /// <summary>
        /// IsDelete
        /// </summary>
        public bool IsDelete { get; set; }

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
        /// ResolvedBy
        /// </summary>
        public string? ResolvedBy { get; set; }

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

