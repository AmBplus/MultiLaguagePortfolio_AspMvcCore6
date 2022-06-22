using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.ProjectModel;

namespace Data.Map;

public class MapPersianProject : IEntityTypeConfiguration<PersianProject>
{
    public void Configure(EntityTypeBuilder<PersianProject> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Title).HasMaxLength(200);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Description).HasColumnType("nvarchar(750)");
        builder.Property(x => x.ImagePath).HasColumnType("nvarchar(250)");
    }
}