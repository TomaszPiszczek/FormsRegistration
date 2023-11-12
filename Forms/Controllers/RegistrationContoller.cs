using Forms.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forms.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                // Przetwarzanie danych, np. zapis do bazy danych
                return View("Success");
            }

            // Jeśli model jest niepoprawny, zwróć widok z błędami walidacji
            return View("Index", model);
        }
    }
}
