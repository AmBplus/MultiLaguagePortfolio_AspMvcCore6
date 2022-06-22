namespace Models.ProjectModel;

public class PersianProject : IBaseModelDomain
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public bool IsSpecial { get; set; } = false;
    public int ClientId { get; set; }

    public DateTime DateTime { get; set; }
    public Client client { get; set; }

    public PersianProject()
    {
        DateTime = DateTime.Now;
    }
}