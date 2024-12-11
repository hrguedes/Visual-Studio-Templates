using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace $rootnamespace$;

public class $safeitemname$ : IEntityTypeConfiguration<$fileinputname$>
{
    public void Configure(EntityTypeBuilder<$fileinputname$> builder)
    {
        builder.ToTable("", "");
        builder.Ignore(x => x.Notifications);
        builder.Ignore(x => x.IsValid);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.Created).IsRequired().HasColumnType("timestamptz").HasColumnName("created");
        builder.Property(x => x.Modified).HasColumnType("timestamptz").HasColumnName("modified");
        builder.Property(x => x.ActiveRegister)
            .IsRequired()
            .HasColumnType("boolean")
            .HasColumnName("active_register");
        builder.Property(x => x.CompanyOwnerId)
            .IsRequired()
            .HasColumnType("integer")
            .HasColumnName("company_owner_id");
        builder.Property(x => x.UserOwnerId)
            .IsRequired()
            .HasColumnType("integer")
            .HasColumnName("user_owner_id");

            // CODE
    }
}

