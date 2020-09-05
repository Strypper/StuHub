using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace StuHub.Components.Cards.StuHub
{
    public sealed partial class SchoolStoryCard : UserControl
    {
        public string StudentName
        {
            get { return (string)GetValue(PersonNameProperty); }
            set { SetValue(PersonNameProperty, value); }
        }

        public static readonly DependencyProperty PersonNameProperty =
            DependencyProperty.Register("StudentName", typeof(string), typeof(SchoolStoryCard), null);

        public string SchoolName
        {
            get { return (string)GetValue(SchoolNameProperty); }
            set { SetValue(SchoolNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SchoolName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SchoolNameProperty =
            DependencyProperty.Register("SchoolName", typeof(string), typeof(SchoolStoryCard), null);

        public string ProfileUrl
        {
            get { return (string)GetValue(ProfileUrlProperty); }
            set { SetValue(ProfileUrlProperty, value); }
        }

        public static readonly DependencyProperty ProfileUrlProperty =
            DependencyProperty.Register("ProfileUrl", typeof(string), typeof(SchoolStoryCard), null);

        public string SchoolUrl
        {
            get { return (string)GetValue(SchoolUrlProperty); }
            set { SetValue(SchoolUrlProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SchoolUrl.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SchoolUrlProperty =
            DependencyProperty.Register("SchoolUrl", typeof(string), typeof(SchoolStoryCard), null);

        public string StoryImage
        {
            get { return (string)GetValue(StoryImageProperty); }
            set { SetValue(StoryImageProperty, value); }
        }

        public static readonly DependencyProperty StoryImageProperty =
            DependencyProperty.Register("StoryImage", typeof(string), typeof(SchoolStoryCard), null);

        public string Story
        {
            get { return (string)GetValue(StoryProperty); }
            set { SetValue(StoryProperty, value); }
        }

        public static readonly DependencyProperty StoryProperty =
            DependencyProperty.Register("Story", typeof(string), typeof(SchoolStoryCard), null);

        public SchoolStoryCard()
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
