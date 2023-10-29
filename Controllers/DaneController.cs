using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System_zarządzania_błędami.Models;

namespace System_zarządzania_błędami.Controllers
{
    public class DaneController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            return View("Wynik", dane);
        }
        public IActionResult Wynik(Dane dane)
        {

            return View(dane);
        }

    }
}
