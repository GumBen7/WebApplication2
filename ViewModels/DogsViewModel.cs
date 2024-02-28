using WebApplication1.Models;

namespace WebApplication1.ViewModels {
    public class DogsViewModel(List<Dog> dogs) {
        public List<Dog> Dogs { get; set; } = dogs;
    }
}
