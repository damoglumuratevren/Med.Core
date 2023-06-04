using Med.Core.Domain.Entities.ApplicationUserEN;
using Med.Core.Persistance.Constans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Med.Core.Persistance.ORM.EntityFramework.Configurations.ApplicationUserConfi
{
  public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
  {
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
      builder.ToTable(TableNamesOrColoumnNames.ApplicationUsers).HasKey(k => k.Id);
      builder.Property(p => p.Id).HasColumnName(TableNamesOrColoumnNames.Id).HasMaxLength(36).IsRequired();
      builder.Property(p => p.Name).HasColumnName(TableNamesOrColoumnNames.Name).HasMaxLength(150).IsRequired();
      builder.Property(p => p.Surname).HasColumnName(TableNamesOrColoumnNames.Surname).HasMaxLength(150).IsRequired();

      builder.Property(p => p.TcknOrVkn).HasColumnName("TcknOrVkn").HasMaxLength(50).IsRequired();
      builder.HasIndex(p => p.TcknOrVkn).IsUnique();

      builder.Property(p => p.Email).HasColumnName("Email").HasMaxLength(150).IsRequired();
      builder.HasIndex(p => p.Email).IsUnique();

      builder.Property(p => p.Password).HasColumnName("Password").HasMaxLength(350).IsRequired();
      builder.Property(p => p.ProfilImageId).HasColumnName("ProfilImageId").HasMaxLength(36).IsRequired();
      builder.Property(p => p.IsTurkish).HasColumnName("IsTurkish").IsRequired();
      
      builder.Property(p => p.CreatedBy).HasColumnName(TableNamesOrColoumnNames.CreatedBy).HasMaxLength(36).IsRequired();
      builder.Property(p => p.CreatedDate).HasColumnName(TableNamesOrColoumnNames.CreatedDate).IsRequired().IsRequired();
      builder.Property(p => p.UpdatedBy).HasColumnName(TableNamesOrColoumnNames.UpdatedBy).HasMaxLength(36).IsRequired(false);
      builder.Property(p => p.UpdatedDate).HasColumnName(TableNamesOrColoumnNames.UpdatedDate).IsRequired(false);
      builder.Property(p => p.DeletedBy).HasColumnName(TableNamesOrColoumnNames.DeletedBy).HasMaxLength(36).IsRequired(false);
      builder.Property(p => p.DeletedDate).HasColumnName(TableNamesOrColoumnNames.DeletedDate).IsRequired(false);
    }
  }
}
