using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace StuHub.Views.Pages.Stuhub.Components
{
    public sealed partial class SchoolStoryComponent : UserControl
    {
        public string PersonName
        {
            get { return (string)GetValue(PersonNameProperty); }
            set { SetValue(PersonNameProperty, value); }
        }

        public static readonly DependencyProperty PersonNameProperty =
            DependencyProperty.Register("PersonName", typeof(string), typeof(SchoolStoryComponent), null);

        public string ProfileUrl
        {
            get { return (string)GetValue(ProfileUrlProperty); }
            set { SetValue(ProfileUrlProperty, value); }
        }

        public static readonly DependencyProperty ProfileUrlProperty =
            DependencyProperty.Register("ProfileUrl", typeof(string), typeof(SchoolStoryComponent), null);

        public string StoryImage
        {
            get { return (string)GetValue(StoryImageProperty); }
            set { SetValue(StoryImageProperty, value); }
        }

        public static readonly DependencyProperty StoryImageProperty =
            DependencyProperty.Register("StoryImage", typeof(string), typeof(SchoolStoryComponent), null);

        public string Story
        {
            get { return (string)GetValue(StoryProperty); }
            set { SetValue(StoryProperty, value); }
        }

        public static readonly DependencyProperty StoryProperty =
            DependencyProperty.Register("Story", typeof(string), typeof(SchoolStoryComponent), null);

        public SchoolStoryComponent()
        {
            this.InitializeComponent();
        }
        private void CommentButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton tB = sender as ToggleButton;
            if (tB != null)
            {
                if (tB.IsChecked == true)
                {
                    tB.IsChecked = true;
                    CommentSection.Visibility = Visibility.Visible;
                }
                else
                {
                    tB.IsChecked = false;
                    CommentSection.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
