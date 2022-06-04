using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.ArticleModel;

namespace Data.Map;

public class MapEnglishArticle : IEntityTypeConfiguration<EnglishArticle>
{
    public void Configure(EntityTypeBuilder<EnglishArticle> builder)
    {
        builder.HasOne(x => x.Client).WithOne(x => x.EnglishArticle).HasForeignKey<EnglishArticle>(x => x.ClientId);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Title).HasMaxLength(80);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Description).HasColumnType("varchar(450)");
        builder.Property(x => x.Image).HasColumnType("nvarchar(150)");
    }
}