using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.ProjectModel;

namespace Data.Map;

public class MapEnglishProject : IEntityTypeConfiguration<EnglishProject>
{
    public void Configure(EntityTypeBuilder<EnglishProject> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Title).HasMaxLength(200);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Description).HasColumnType("varchar(750)");
        builder.Property(x => x.ImagePath).HasColumnType("nvarchar(250)");
    }
}