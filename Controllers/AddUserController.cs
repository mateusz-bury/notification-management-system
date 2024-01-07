using Microsoft.AspNetCore.Mvc;
using System_zarządzania_błędami.Data;
using System_zarządzania_błędami.Entities;

namespace System_zarządzania_błędami.Controllers
{
    public class AddUserController : Controller
    {


        private readonly ApplicationDbContext _context;

        public AddUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddUser(Users newUser)
        {
            try
            {
                // Dodaj nowego użytkownika do bazy danych
                _context.Users.Add(newUser);
                _context.SaveChanges();

                // Dodatkowe czynności, jeśli są potrzebne (np. przekierowanie do innej strony)
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                // Obsługa błędów, np. logowanie
                ModelState.AddModelError("", "Wystąpił błąd podczas dodawania użytkownika do bazy danych.");
                return View(newUser); // Lub inny widok z błędem
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
