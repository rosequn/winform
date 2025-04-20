using WinFormsApp31_03.Enums;

namespace WinFormsApp31_03.Models;
partial class User
{
    public User() { }


    /// <summary>
    /// Create
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <param name="fullName"></param>
    /// <param name="createdBy"></param>
    /// <returns></returns>
    public static User Create(string username, string password, string fullName, int createdBy)
    {
        var res = new User
        {
            Username = username,
            Password = password,
            FullName = fullName,
            CreatedBy = createdBy,
            CreatedOn = DateTime.Now,
        };

        return res;
    }

    /// <summary>
    /// Update
    /// </summary>
    /// <param name="username"></param>
    /// <param name="alertType"></param>
    /// <param name="role"></param>
    /// <param name="fullName"></param>
    /// <param name="modifiedBy"></param>
    public void Update(string? username, string phoneNumber, int role, string? fullName, int? modifiedBy)
    {

        Username = username + "";
        PhoneNumber = phoneNumber + "";
        FullName = fullName + "";
        Role = role;

        ModifiedBy = modifiedBy;
        ModifiedOn = DateTime.Now;
    }


    /// <summary>
    /// UpdateStatus
    /// </summary>
    /// <param name="status"></param>
    /// <param name="modifiedBy"></param>
    public void UpdateStatus(int status, int? modifiedBy)
    {

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
            UserID = UserId,
            Username = Username,
            FullName = FullName,
            Email = Email,
            PhoneNumber = PhoneNumber,
            Role = Role,
            IsActive = IsActive,
            IsDelete = IsDelete,
            CreatedOn = CreatedOn,
            CreatedBy = CreatedBy,
            LastLogin = LastLogin,
            ModifiedBy = ModifiedBy,
            ModifiedOn = ModifiedOn,
        };
    }

    /// <summary>
    /// BaseDto
    /// </summary>
    public class BaseDto
    {
        /// <summary>
        /// UserID
        /// </summary>
        public int? UserID { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public int Role { get; set; }

        /// <summary>
        /// RoleName
        /// </summary>
        public string RoleName
        {
            get
            {
                return EnumHelper.GetDescription((UserRole)Role);
            }
        }

        /// <summary>
        /// UserID
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public bool? IsDelete { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public int? CreatedBy { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public int? ModifiedBy { get; set; }

        /// <summary>
        /// UserID
        /// </summary>
        public DateTime? ModifiedOn { get; set; }
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

