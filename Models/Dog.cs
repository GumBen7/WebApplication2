namespace WebApplication1.Models {
    public class Dog(string name, int age) {
        public int Id { get; set; }
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
    }
}
