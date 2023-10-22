using Microsoft.AspNetCore.Mvc;
using System_zarządzania_błędami.Data;
using System_zarządzania_błędami.Models;

namespace System_zarządzania_błędami.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
