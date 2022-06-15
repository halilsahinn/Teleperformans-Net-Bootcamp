using Microsoft.AspNetCore.Mvc;

namespace Hafta1.Controllers.Base
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
