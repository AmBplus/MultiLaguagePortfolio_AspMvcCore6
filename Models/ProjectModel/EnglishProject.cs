﻿namespace Models.ProjectModel;

public class EnglishProject : IBaseModelDomain
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public bool IsSpecial { get; set; } = false;
    public int ClientId { get; set; }
    public virtual Client Client { get; set; }
    public DateTime DateTime { get; set; }

    public EnglishProject()
    {
        DateTime = DateTime.Now;
    }
}