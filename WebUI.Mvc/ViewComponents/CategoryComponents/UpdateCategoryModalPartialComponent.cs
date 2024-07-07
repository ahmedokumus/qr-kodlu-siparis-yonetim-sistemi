using Microsoft.AspNetCore.Mvc;

namespace WebUI.Mvc.ViewComponents.CategoryComponents;

public class UpdateCategoryModalPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke() => View();
}