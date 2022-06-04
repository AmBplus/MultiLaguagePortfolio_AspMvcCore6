using Models.ArticleModel;
using Models.ProjectModel;

namespace Models;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual EnglishProject EnglishProject { get; set; }
    public virtual PersianProject PersianProject { get; set; }
    public virtual EnglishArticle EnglishArticle { get; set; }
    public virtual PersianAticle PersianAticle { get; set; }
}