using Microsoft.AspNetCore.Mvc;
using WebApplication1.Databases;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers {
    public class AddingController : Controller {
        [HttpGet]
        public IActionResult Index() {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AddingViewModel addingViewModel) {
            switch (addingViewModel.PetType) {
                case Models.PetTypes.Cat:
                    Database.AddCat(new(addingViewModel.Name, addingViewModel.Age));
                    break;
                default:
                    Database.AddDog(new(addingViewModel.Name, addingViewModel.Age));
                    break;
            }
            return RedirectToAction("Index");
        }
    }
}
