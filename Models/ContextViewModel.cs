namespace Models;

public class ContextViewModel
{
    public ContextViewModel(IBaseModelDomain[] articleListModel, IBaseModelDomain[] projectListModel)
    {
        ArticleListModel = articleListModel;
        ProjectListModel = projectListModel;
    }


    public IBaseModelDomain[] ArticleListModel { get; set; }
    public IBaseModelDomain[] ProjectListModel { get; set; }
}