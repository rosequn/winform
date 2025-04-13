using System.Text.Json.Serialization;
using WinFormsApp31_03.Enums;

namespace WinFormsApp31_03.Models;

partial class PumpStation
{
    public PumpStation() { }

    /// <summary>
    /// Create
    /// </summary>
    /// <param name="name"></param>
    /// <param name="location"></param>
    /// <param name="description"></param>
    /// <param name="createdBy"></param>
    /// <returns></returns>
    public static PumpStation Create(string? name, string? location, string? description, int createdBy)
    {
        var res = new PumpStation
        {
            StationName = name + "",
            Location = location + "",
            Description = description + "",

            CreatedBy = createdBy,
            CreatedOn = DateTime.Now,
        };

        return res;
    }

    /// <summary>
    /// Update
    /// </summary>
    /// <param name="name"></param>
    /// <param name="location"></param> 
    /// <param name="description"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    public void Update(string? name, string? location, string? description, int status, int modifiedBy)
    {
        StationName = name + "";
        Location = location + "";
        Description = description + "";
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
        ModifiedOn = DateTime.UtcNow;
    }

    public SearchDto ToSearchDto()
    {
        var res = ToBaseDto<SearchDto>();
        return res;
    }

    public SearchCbDto ToSearchCbDto()
    {
        var res = new SearchCbDto();

        res.StationId = StationId;
        res.StationName = StationName;

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
            StationId = StationId,
            StationName = StationName,
            Location = Location,
            Description = Description,
            Status = Status,
            CreatedBy = CreatedBy,
            CreatedOn = CreatedOn,
            ModifiedOn = ModifiedOn,
            ModifiedBy = ModifiedBy
        };
    }

    /// <summary>
    /// BaseDto
    /// </summary>
    public class BaseDto
    {
        #region -- Properties --

        /// <summary>
        /// StationId
        /// </summary>
        public int StationId { get; set; }

        /// <summary>
        /// StationName
        /// </summary>
        public string? StationName { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        public string? Location { get; set; }

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
        /// StatusName
        /// </summary>
        public string StatusName
        {
            get
            {
                return EnumHelper.GetDescription((PumpStatus)Status);
            }
        }

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
        /// StationId
        /// </summary>
        public int StationId { get; set; }

        /// <summary>
        /// StationName
        /// </summary>
        public string? StationName { get; set; }
    }
}

