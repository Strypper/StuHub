using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using StuHub.Views;
using Windows.ApplicationModel.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StuHub
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginRegisterView : Page
    {
        public LoginRegisterView()
        {
            this.InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(MainFrame));
    }
}
