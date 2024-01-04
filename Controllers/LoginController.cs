using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System_zarządzania_błędami.Data;
using System_zarządzania_błędami.Entities;
using System_zarządzania_błędami.Models;

namespace System_zarządzania_błędami.Controllers
{
    public class LoginController : Controller
    {

        private readonly ApplicationDbContext _db;
        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _db.Users.FirstOrDefault(u => u.Login == model.Login);

                if (user != null && VerifyPassword(user, model.Password))
                {
                    // Zaloguj użytkownika
                    HttpContext.Session.SetString("UserId", user.Id.ToString());
                    HttpContext.Session.SetString("IsAdmin", user.IsAdmin.ToString());

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Nieprawidłowe dane logowania.");
            }

            return View("Index", model);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }
        private bool VerifyPassword(Users user, string password)
        {
            return true;
        }
    }
}
