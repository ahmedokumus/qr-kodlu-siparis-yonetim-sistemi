using WebUI.Mvc.ViewModels.Common;

namespace WebUI.Mvc.ViewModels.CategoryViewModels;

public class ResultCategoryViewModel : BaseViewModel
{
    public ResultCategoryViewModel(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
	public bool Status { get; set; }
}