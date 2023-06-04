using Med.Core.Application.Enums.ApplicationUserIdentity;
namespace Med.Core.Domain.Entities.ApplicationUserEn

{
  public class ApplicationUserIdentity : BaseEntity
  {
    public ApplicationUserIdentity(string applicationUserId, string countryId,  short dualNationality, string fatherName, string motherName)
    {
      Id = Guid.NewGuid().ToString();
      ApplicationUserId = applicationUserId;
      CountryId = countryId;
      DualNationality = dualNationality;
      FatherName = fatherName;
      MotherName = motherName;
    }
    public ApplicationUserIdentity()
    {

    }
    public string ApplicationUserId { get; set; }
    public string CountryId { get; set; }
    public short DualNationality { get; set; } = 0;
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string? MaidenName { get; set; }
    public string PlaceOfBirth { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int MaritalStatusId { get; set; }
    public int GenderId { get; set; }
    public int BloodTypeId { get; set; }
    public string? Serial { get; set; }
    public string? SerialCode { get; set; }
    public int? ReligiousId { get; set; }
    public int? RegisteredTownId { get; set; }
    public string? ValumeNo { get; set; }
    public string? FamilyOrderNo { get; set; }
    public string? GivenPlace { get; set; }
    public string? GivenReason { get; set; }
    public DateTime? GivenDate { get; set; }
    public string? RegisterNo { get; set; }
    public string? PassportNo { get; set; }
    public string? RegisteredVillage { get; set; }
    public string? OrderNo { get; set; }
    public string? PassportImageId { get; set; }
    public string? NewSerialNo { get; set; }
    public DateTime? ExpiryDate { get; set; }

  }
}
