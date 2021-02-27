using StuHub.Views.Pages.Stuhub;
using StuHub.Views.Pages.Tutor.CollegeSubjectRequest;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace StuHub.Views
{
    public sealed partial class MainFrame : Page
    {
        public MainFrame()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void KeyboardAccelerator_Invoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args) => Search.Focus(FocusState.Programmatic);

        private void NavigationViewPanel_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            Microsoft.UI.Xaml.Controls.NavigationViewItem item = args.SelectedItem as Microsoft.UI.Xaml.Controls.NavigationViewItem;
            NavigateFrame(item);
        }

        private void NavigateFrame(Microsoft.UI.Xaml.Controls.NavigationViewItem item)
        {
            switch (item.Name)
            {
                case "Home":
                    MainFrameNav.Navigate(typeof(StuHubMainFrame));
                    break;

                case "CollegeSubject":
                    MainFrameNav.Navigate(typeof(CollegeSubjectRequest));
                    break;
            }
        }
    }
}
