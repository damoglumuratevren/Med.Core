using Med.Core.Domain.Entities.ApplicationUserEn;
using Med.Core.Persistance.Constans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Med.Core.Persistance.ORM.EntityFramework.Configurations.ApplicationUserConfi
{
  public class ApplicationUserContactConfiguration : IEntityTypeConfiguration<ApplicationUserContact>
  {
    public void Configure(EntityTypeBuilder<ApplicationUserContact> builder)
    {
      builder.ToTable(TableNamesOrColoumnNames.ApplicationUserContacts).HasKey(k => k.Id);
      builder.Property(p => p.Id).HasColumnName(TableNamesOrColoumnNames.Id).HasMaxLength(36).IsRequired();

      builder.Property(p => p.ApplicationUserId).HasColumnName("ApplicationUserId").HasMaxLength(36).IsRequired();
      builder.Property(p => p.ContactType).HasColumnName("ContactType").IsRequired();
      builder.Property(p => p.Value).HasColumnName("Value").HasMaxLength(36).IsRequired();
      builder.Property(p => p.IsDefault).HasColumnName("IsDefault").IsRequired();
      builder.Property(p => p.IsMain).HasColumnName("IsMain").IsRequired();

      builder.Property(p => p.CreatedBy).HasColumnName(TableNamesOrColoumnNames.CreatedBy).HasMaxLength(36).IsRequired();
      builder.Property(p => p.CreatedDate).HasColumnName(TableNamesOrColoumnNames.CreatedDate).IsRequired().IsRequired();
      builder.Property(p => p.UpdatedBy).HasColumnName(TableNamesOrColoumnNames.UpdatedBy).HasMaxLength(36).IsRequired(false);
      builder.Property(p => p.UpdatedDate).HasColumnName(TableNamesOrColoumnNames.UpdatedDate).IsRequired(false);
      builder.Property(p => p.DeletedBy).HasColumnName(TableNamesOrColoumnNames.DeletedBy).HasMaxLength(36).IsRequired(false);
      builder.Property(p => p.DeletedDate).HasColumnName(TableNamesOrColoumnNames.DeletedDate).IsRequired(false);

    }
  }
}
