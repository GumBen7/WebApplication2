using Microsoft.AspNetCore.Mvc;
using WebApplication1.Databases;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers {
    public class PetsController : Controller {
        public IActionResult Index() {
            PetsViewModel petsViewModel = new(Database.Dogs, Database.Cats);
            return View(petsViewModel);
        }
    }
}
