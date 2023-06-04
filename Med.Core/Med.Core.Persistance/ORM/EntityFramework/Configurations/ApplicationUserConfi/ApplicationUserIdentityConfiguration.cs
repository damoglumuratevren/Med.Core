using Med.Core.Domain.Entities.ApplicationUserEn;
using Med.Core.Persistance.Constans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Med.Core.Persistance.ORM.EntityFramework.Configurations.ApplicationUserConfi
{
  public class ApplicationUserIdentityConfiguration : IEntityTypeConfiguration<ApplicationUserIdentity>
  {
    public void Configure(EntityTypeBuilder<ApplicationUserIdentity> builder)
    {
      builder.ToTable(TableNamesOrColoumnNames.ApplicationUserIdentities).HasKey(k => k.Id);
      builder.Property(p => p.Id).HasColumnName(TableNamesOrColoumnNames.Id).HasMaxLength(36).IsRequired();
      builder.Property(p => p.ApplicationUserId).HasColumnName("ApplicationUserId").HasMaxLength(36).IsRequired();
      builder.Property(p => p.CountryId).HasColumnName(TableNamesOrColoumnNames.CountryId).HasMaxLength(36).IsRequired();
      builder.Property(p => p.DualNationality).HasColumnName("DualNationality").IsRequired();
      builder.Property(p => p.FatherName).HasColumnName("FatherName").HasMaxLength(75).IsRequired();
      builder.Property(p => p.MotherName).HasColumnName("MotherName").HasMaxLength(75).IsRequired();
      builder.Property(p => p.MaidenName).HasColumnName("MaidenName").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.PlaceOfBirth).HasColumnName("PlaceOfBirth").HasMaxLength(75).IsRequired();
      builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
      builder.Property(p => p.MaritalStatusId).HasColumnName("MaritalStatusId").IsRequired();
      builder.Property(p => p.GenderId).HasColumnName("GenderId").IsRequired();
      builder.Property(p => p.Serial).HasColumnName("Serial").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.BloodTypeId).HasColumnName("BloodTypeId").IsRequired();
      builder.Property(p => p.SerialCode).HasColumnName("SerialCode").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.ReligiousId).HasColumnName("ReligiousId").IsRequired(false);
      builder.Property(p => p.RegisteredTownId).HasColumnName("RegisteredTownId").IsRequired(false);
      builder.Property(p => p.ValumeNo).HasColumnName("ValumeNo").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.FamilyOrderNo).HasColumnName("FamilyOrderNo").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.GivenPlace).HasColumnName("GivenPlace").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.GivenReason).HasColumnName("GivenReason").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.GivenDate).HasColumnName("GivenDate").IsRequired(false);
      builder.Property(p => p.RegisterNo).HasColumnName("RegisterNo").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.PassportNo).HasColumnName("PassportNo").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.RegisteredVillage).HasColumnName("RegisteredVillage").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.OrderNo).HasColumnName("OrderNo").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.PassportImageId).HasColumnName("PassportImageId").HasMaxLength(36).IsRequired(false);
      builder.Property(p => p.NewSerialNo).HasColumnName("NewSerialNo").HasMaxLength(75).IsRequired(false);
      builder.Property(p => p.ExpiryDate).HasColumnName("ExpiryDate").IsRequired(false);


      builder.Property(p => p.CreatedBy).HasColumnName(TableNamesOrColoumnNames.CreatedBy).HasMaxLength(36).IsRequired();
      builder.Property(p => p.CreatedDate).HasColumnName(TableNamesOrColoumnNames.CreatedDate).IsRequired().IsRequired();
      builder.Property(p => p.UpdatedBy).HasColumnName(TableNamesOrColoumnNames.UpdatedBy).HasMaxLength(36).IsRequired(false);
      builder.Property(p => p.UpdatedDate).HasColumnName(TableNamesOrColoumnNames.UpdatedDate).IsRequired(false);
      builder.Property(p => p.DeletedBy).HasColumnName(TableNamesOrColoumnNames.DeletedBy).HasMaxLength(36).IsRequired(false);
      builder.Property(p => p.DeletedDate).HasColumnName(TableNamesOrColoumnNames.DeletedDate).IsRequired(false);
    }
  }
}
