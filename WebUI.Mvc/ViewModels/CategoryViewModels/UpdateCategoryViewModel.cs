namespace WebUI.Mvc.ViewModels.CategoryViewModels;

public class UpdateCategoryViewModel
{
    public UpdateCategoryViewModel(string name)
    {
        Name = name;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}