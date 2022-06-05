namespace Models;

public interface IBaseModelDomain
{
    string Title { get; set; }
    string Description { get; set; }
    string Image { get; set; }
    DateTime DateTime { get; set; }
    Client client { get; set; }
}