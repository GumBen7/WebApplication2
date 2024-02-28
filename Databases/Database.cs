using WebApplication1.Models;

namespace WebApplication1.Databases {
    public static class Database {
        public static List<Dog> Dogs { get; set; } = [new("Жучка", 7), new("Шарик", 2)];
        public static List<Cat> Cats { get; set; } = [new Cat("Мурка", 1)];

        public static void AddDog(Dog dog) {
            Dogs.Add(dog);
        }
        public static void AddCat(Cat cat) {
            Cats.Add(cat);
        }
    }
}
