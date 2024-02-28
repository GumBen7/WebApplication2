using Microsoft.AspNetCore.Mvc;
using WebApplication1.Databases;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers {
    public class CatsController : Controller {
        public IActionResult Index() {
            CatsViewModel catsViewModel = new(Database.Cats);
            return View(catsViewModel);
        }
    }
}
