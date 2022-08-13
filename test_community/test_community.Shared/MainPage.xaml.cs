using Microsoft.UI.Xaml.Controls;

namespace test_community
{
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel = new MainPageViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = ViewModel;
        }
    }
}
