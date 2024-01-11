using Microsoft.AspNetCore.Mvc;
using System_zarządzania_błędami.Data;
using System_zarządzania_błędami.Entities;
using System_zarządzania_błędami.Models;

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
        public IActionResult AddUser(AddUserModel newUser)
        {
            try
            {

                var userEntitie = new Users()
                {
                    Email = newUser.Email,
                    IsAdmin = newUser.IsAdmin,
                    LastName = newUser.LastName,
                    Login = newUser.Login,
                    Password = newUser.Password,
                    Name = newUser.Name,
                };

                // Dodaj nowego użytkownika do bazy danych
                _context.Users.Add(userEntitie);
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

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        public IActionResult Index()
        {

            var model = _context.Users.Select(User => new AddUserModel()
            {
                Id = User.Id,
                Email = User.Email,
                IsAdmin = User.IsAdmin,
                LastName = User.LastName,
                Login = User.Login,
                Password = User.Password,
                Name = User.Name,
            }).ToList();

            return View(model);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var usersFromDb = _context.Users.Find(id);
            if (usersFromDb == null)
            {
                return NotFound();
            }
            var model = new AddUserModel()
            {

                Id = usersFromDb.Id,
                Email = usersFromDb.Email,
                IsAdmin = usersFromDb.IsAdmin,
                LastName = usersFromDb.LastName,
                Login = usersFromDb.Login,
                Password = usersFromDb.Password,
                Name = usersFromDb.Name,

            };
            return View(model);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AddUserModel model)
        {
            var user = _context.Users.Where(x => x.Id == model.Id).FirstOrDefault();
            var users = _context.Users.Where(x => x.Id != model.Id).ToList();

            if (user != null)
            {
                if (users.Any(a => a.Login == model.Login))

                    ModelState.AddModelError("Login", "Login już istnieje");

                if (ModelState.IsValid)
                {
                    user.Name = model.Name;
                    user.Password = model.Password;
                    user.IsAdmin = model.IsAdmin;
                    user.LastName = model.LastName;
                    user.Login = model.Login;
                    user.Email = model.Email;

                    _context.SaveChanges();
                    TempData["edit"] = "Wpis został wyedytowany";
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }


    }






}
