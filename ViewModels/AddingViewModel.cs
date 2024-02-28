using WebApplication1.Models;

namespace WebApplication1.ViewModels {
    public class AddingViewModel {
        public string Name { get; set; }
        public int Age { get; set; }
        public PetTypes PetType { get; set; }
        public AddingViewModel() { }
        public AddingViewModel(string name, int age, PetTypes petType) { 
            Name = name;
            Age = age;
            PetType = petType;
        }

        
    }
}
