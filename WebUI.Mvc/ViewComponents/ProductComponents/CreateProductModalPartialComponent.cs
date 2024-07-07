using Microsoft.AspNetCore.Mvc;

namespace WebUI.Mvc.ViewComponents.ProductComponents;

public class CreateProductModalPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}