using Microsoft.AspNetCore.Mvc;
using System_zarządzania_błędami.Models;

public class DaneController : Controller
{
    [HttpGet]
    public ActionResult Contact()
    {
        return View();
    }

    [HttpPost]
    public ActionResult SubmitForm(ContactFormModel model)
    {
        // Handle the form submission, e.g., send an email or save data to a database.

        // Redirect to a thank you page or back to the form.
        return RedirectToAction("ThankYou");
    }

    public ActionResult ThankYou()
    {
        return View();
    }
}
