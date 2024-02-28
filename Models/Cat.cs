namespace WebApplication1.Models {
    public class Cat(string name, int age) {
        public int Id { get; set; }
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
    }
}
