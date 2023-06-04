using Med.Core.Domain.Entities.ApplicationUserEn;

namespace Med.Core.Domain.Entities.ApplicationUserEN
{
  public class ApplicationUser : BaseEntity //root
  {
    public string Name { get; set; }
    public string Surname { get; set; }
    public string TcknOrVkn { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ProfilImageId { get; set; }
    public bool IsTurkish { get; set; } = true;

    //childs
    private List<ApplicationUserIdentity> _applicationUserIdentities=new List<ApplicationUserIdentity>(); 
    private List<ApplicationUserContact> _applicationUserContacts=new List<ApplicationUserContact>();

    public IReadOnlyCollection<ApplicationUserContact> ApplicationUserContacts => _applicationUserContacts;
    public IReadOnlyCollection<ApplicationUserIdentity> ApplicationUserIdentities => _applicationUserIdentities;  
    
    public ApplicationUser()
    {

    }

    public ApplicationUser(string name, string surname, string tcknOrVkn, string email, string password, string profilImageId, bool isTurkish)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
      Surname = surname;
      TcknOrVkn = tcknOrVkn;
      Email = email;
      Password = password;
      ProfilImageId = profilImageId;
      IsTurkish = isTurkish;
    }
    public void Test(string a)
    {
      
    }
  }
}
