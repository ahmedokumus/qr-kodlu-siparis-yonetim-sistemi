namespace WebUI.Mvc.ViewModels.CategoryViewModels;

public class CreateCategoryViewModel
{
    public CreateCategoryViewModel(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public bool Status { get; set; }
}