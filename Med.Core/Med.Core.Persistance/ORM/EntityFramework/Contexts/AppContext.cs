using Med.Core.Domain.Entities.ApplicationUserEN;
using Microsoft.EntityFrameworkCore;

namespace Med.Core.Persistance.ORM.EntityFramework.Contexts
{
  public class AppContext : DbContext
  {
    public AppContext()
    {

    }
    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {

    }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

    }
  }
}
