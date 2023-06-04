namespace Med.Core.Domain.Entities.CommanEntiity
{
  public class Country : BaseEntity
  {
    public string Name { get; set; }
    public Country()
    {

    }

    public Country(string name)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
    }
  }
}
