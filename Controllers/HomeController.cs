using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            HomeViewModel homeViewModel = new(DateTime.Now.ToString());
            return View(homeViewModel);
        }
    }
}
