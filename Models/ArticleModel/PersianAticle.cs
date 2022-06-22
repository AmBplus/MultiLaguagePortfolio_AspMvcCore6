namespace Models.ArticleModel;

public class PersianAticle : IBaseModelDomain
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public int ClientId { get; set; }

    public DateTime DateTime { get; set; }
    public Client client { get; set; }

    public PersianAticle()
    {
        DateTime = DateTime.Now;
    }
}