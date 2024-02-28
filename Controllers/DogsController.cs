using Microsoft.AspNetCore.Mvc;
using WebApplication1.Databases;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers {
    public class DogsController : Controller {
        public IActionResult Index() {
            DogsViewModel dogsViewModel = new(Database.Dogs);
            return View(dogsViewModel);
        }
    }
}
