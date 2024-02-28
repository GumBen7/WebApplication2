using WebApplication1.Models;

namespace WebApplication1.ViewModels {
    public class CatsViewModel(List<Cat> cats) {
        public List<Cat> Cats { get; set; } = cats;
    }
}
