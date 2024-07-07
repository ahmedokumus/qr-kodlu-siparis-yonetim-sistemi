using Microsoft.AspNetCore.Mvc;

namespace WebUI.Mvc.ViewComponents.ProductComponents;

public class UpdateProductModalPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}