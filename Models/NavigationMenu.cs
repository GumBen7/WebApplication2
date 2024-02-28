using WebApplication1.Databases;

namespace WebApplication1.Models {
    public class NavigationMenu() {
        public List<MenuItem> MenuItems { get; set; } = Database.MenuItems;
    }
}
