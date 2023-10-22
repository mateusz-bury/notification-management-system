using Microsoft.AspNetCore.Mvc;

namespace System_zarządzania_błędami.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
