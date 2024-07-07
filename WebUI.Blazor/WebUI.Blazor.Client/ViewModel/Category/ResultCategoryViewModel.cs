using WebUI.Blazor.Client.ViewModel.Common;

namespace WebUI.Blazor.Client.ViewModel.Category;

public class ResultCategoryViewModel : BaseViewModel
{
    public ResultCategoryViewModel(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public bool Status { get; set; }
}