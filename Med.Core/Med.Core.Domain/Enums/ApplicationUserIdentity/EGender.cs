using System.ComponentModel.DataAnnotations;

namespace Med.Core.Application.Enums.ApplicationUserIdentity
{
  [Serializable]
  public enum EGender
  {
    [Display(Name = "Erkek")]
    ERKEK = 1,
    [Display(Name = "Kadın")]
    KADIN = 2


    //   [Display(Name = "Cep Telefonu")]
    //    CEPTELEFONU = 1,
    //[Display(Name = "EV Telefonu")]
    //EVTELEFONU = 2,
    //[Display(Name = "Email")]
    //Email = 3
  }
}
