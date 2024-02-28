namespace WebApplication1.ViewModels {
    public class HomeViewModel(string dateString) {
        public List<string> Dates { get; set; } = [dateString, dateString, dateString];
    }
}
