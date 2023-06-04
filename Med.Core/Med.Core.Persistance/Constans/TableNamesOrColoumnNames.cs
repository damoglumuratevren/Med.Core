using Med.Core.Domain.Entities.ApplicationUserEN;

namespace Med.Core.Persistance.Constans
{
  public static class TableNamesOrColoumnNames
  {
    #region Table name

    #region ApplicationUserEn

    public static string ApplicationUsers = nameof(ApplicationUsers);
    public static string ApplicationUserContacts = nameof(ApplicationUserContacts);
    public static string ApplicationUserIdentities = nameof(ApplicationUserIdentities);
    #endregion

    #region Common Colon
    public static string Name = nameof(Name);
    public static string Surname = nameof(Surname);
    public static string CountryId = nameof(CountryId);
    #endregion

    //public static string CountryId = nameof(CountryId);
    #endregion



    #region BaseEntity
    public static string Id = nameof(Id);  
    public static string CreatedBy = nameof(CreatedBy);
    public static string CreatedDate = nameof(CreatedDate);
    public static string UpdatedBy = nameof(UpdatedBy);
    public static string UpdatedDate = nameof(UpdatedDate);
    public static string DeletedBy = nameof(DeletedBy);
    public static string DeletedDate = nameof(DeletedDate);
    #endregion
  }
}
