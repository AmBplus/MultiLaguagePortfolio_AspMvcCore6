using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.ProjectModel;

namespace Data.Map;

public class MapEnglishProject : IEntityTypeConfiguration<EnglishProject>
{
    public void Configure(EntityTypeBuilder<EnglishProject> builder)
    {
        builder.HasOne(x => x.Client).WithOne(x => x.EnglishProject).HasForeignKey<EnglishProject>(x => x.ClientId);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Title).HasMaxLength(80);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Description).HasColumnType("varchar(450)");
        builder.Property(x => x.Image).HasColumnType("nvarchar(150)");
    }
}