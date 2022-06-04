using Data.Map;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.ArticleModel;
using Models.ProjectModel;

namespace Server;

public class PortfolioContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<EnglishArticle> EnglishArticles { get; set; }
    public DbSet<PersianAticle> PersianAticles { get; set; }
    public DbSet<PersianProject> PersianProjects { get; set; }
    public DbSet<EnglishProject> EnglishProjects { get; set; }

    public PortfolioContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MapEnglishArticle());
        modelBuilder.ApplyConfiguration(new MapEnglishProject());
        modelBuilder.ApplyConfiguration(new MapPersianArticle());
        modelBuilder.ApplyConfiguration(new MapPersianProject());
        base.OnModelCreating(modelBuilder);
    }
}

