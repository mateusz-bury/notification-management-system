using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System_zarządzania_błędami.Data;
using System_zarządzania_błędami.Entities;
using System_zarządzania_błędami.Models;

namespace System_zarządzania_błędami.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ReportsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ReportModel> model = _db.Reports.Select(a => new ReportModel()
            {
                Id = a.Id,
                Status = a.Status,
                Title = a.Title,
                Description = a.Description,
                SubmissionDate = a.SubmissionDate,
                //Errors = _db.Errors.Where(b => b.Id == a.Errors.Id).ToList(),
                //Priorities = _db.Priorities.Where(c => c.Id == a.Priorities.Id).ToList(),
                ErrorName = a.Errors.Name,
                PriorityName = a.Priorities.Name,
            });

            return View(model);
        }

        //CREATE
        //GET
        public IActionResult Create()
        {

            ReportModel model = new ReportModel()
            {

                Errors = _db.Errors.ToList(),
                Priorities = _db.Priorities.ToList(),

            };

            return View(model);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ReportModel model)
        {

            ModelState.Remove("Errors");
            ModelState.Remove("ErrorName");
            ModelState.Remove("Priorities");
            ModelState.Remove("PriorityName");



            if (ModelState.IsValid)
            {
                var reportEntitie = new Reports()
                {
                    Description = model.Description,
                    Status = false,
                    SubmissionDate = DateTime.Now,
                    Title = model.Title,
                    ErrorsId = model.SelectedErrorId,
                    PrioritiesId = model.SelectedPriorityId

                };

                _db.Reports.Add(reportEntitie);

                _db.SaveChanges();
                TempData["add"] = "Dodano nowy wpis";
                return RedirectToAction("Index");
            }

            model.Errors = _db.Errors.ToList();
            model.Priorities = _db.Priorities.ToList();

            return View(model);
        }
        //EDIT
        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Reports.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Reports model)
        {
            if (model.Title == model.Description?.ToString() || model.Title == null)
            {
                ModelState.AddModelError("Title", "Opis jest niekompletny");
            }

            if (ModelState.IsValid)
            {
                _db.Reports.Update(model);
                _db.SaveChanges();
                TempData["edit"] = "Wpis został wyedytowany";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        //DELETE
        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Reports.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View();
        }
        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Reports.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Reports.Remove(obj);
            _db.SaveChanges();
            TempData["remove"] = "Wpis usunięto";
            return RedirectToAction("Index");
        }
    }
}
