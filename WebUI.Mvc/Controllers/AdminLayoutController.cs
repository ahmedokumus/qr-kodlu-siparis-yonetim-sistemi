using Microsoft.AspNetCore.Mvc;

namespace WebUI.Mvc.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
    }
}
