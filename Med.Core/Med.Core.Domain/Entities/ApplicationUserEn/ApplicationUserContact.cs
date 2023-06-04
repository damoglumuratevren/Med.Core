using Med.Core.Domain.Entities.ApplicationUserEN;

namespace Med.Core.Domain.Entities.ApplicationUserEn
{
  public class ApplicationUserContact : BaseEntity
  {
    public string ApplicationUserId { get; set; }
    public int ContactType { get; set; }
    public string Value { get; set; }
    public bool IsDefault { get; set; }
    public bool IsMain { get; set; } = false;
    public ApplicationUserContact()
    {

    }

    public ApplicationUserContact(string applicationUserId, int contactType, string value, bool isDefault,bool isMain)
    {
      Id = Guid.NewGuid().ToString();
      ApplicationUserId = applicationUserId;
      ContactType = contactType;
      Value = value;
      IsDefault = isDefault;
      IsMain = isMain;
    }
  }
}
