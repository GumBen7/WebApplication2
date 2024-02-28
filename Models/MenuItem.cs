namespace WebApplication1.Models {
    public class MenuItem(string title, string link) {
        public string Title { get; set; } = title;
        public string Link { get; set; } = link;
    }
}
