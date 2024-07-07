using Microsoft.AspNetCore.Mvc;

namespace WebUI.Mvc.ViewComponents.CategoryComponents;

public class CreateCategoryModalPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke() => View();
}