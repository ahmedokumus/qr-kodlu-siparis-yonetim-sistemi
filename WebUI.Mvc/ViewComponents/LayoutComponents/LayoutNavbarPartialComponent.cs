using Microsoft.AspNetCore.Mvc;

namespace WebUI.Mvc.ViewComponents.LayoutComponents;

public class LayoutNavbarPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}