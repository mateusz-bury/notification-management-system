using Microsoft.AspNetCore.Mvc;
using System_zarządzania_błędami.Models;

public class DaneController : Controller
{
    [HttpGet]
    public IActionResult Form()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Form(DaneController dane)
    {
        return View("Wynik", dane);
    }
    public IActionResult Wynik(DaneController dane)
    {

        return View(dane);
    }
}
