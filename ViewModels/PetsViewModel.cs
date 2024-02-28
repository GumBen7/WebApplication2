using WebApplication1.Models;

namespace WebApplication1.ViewModels {
    public class PetsViewModel(List<Dog> dogs, List<Cat> cats) {
        public List<Dog> Dogs { get; set; } = dogs;
        public List<Cat> Cats { get; set; } = cats;
    }
}
