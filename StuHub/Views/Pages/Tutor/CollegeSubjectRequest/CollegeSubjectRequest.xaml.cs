using StuHub.Models.Stuhub;
using System.Collections.ObjectModel;
using System.Numerics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StuHub.Views.Pages.Tutor.CollegeSubjectRequest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CollegeSubjectRequest : Page
    {
        private ObservableCollection<Models.Stuhub.CollegeSubjectRequest> collegeSubjectRequest = new ObservableCollection<Models.Stuhub.CollegeSubjectRequest>();
        public CollegeSubjectRequest()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ExecuteAnimation();
            collegeSubjectRequest = DemoCollegeSubjectRequestData.GetData();
            CollegeSubjectRequestGridView.ItemsSource = collegeSubjectRequest;
        }
        private void ExecuteAnimation()
        {
            MainLayout.Translation = new Vector3(0, 60, 0);
        }

        private void ToggleFilterButton_Click(object sender, RoutedEventArgs e)
        {
            if (ToggleFilterButton.IsChecked == true)
            {
                MainLayout.Translation = new Vector3(0, 120, 0);
                ToggleFilterButton.Rotation = 180;
            }
            else
            {
                MainLayout.Translation = new Vector3(0, 60, 0);
                ToggleFilterButton.Rotation = 0;
            }
        }

        private void RefreshContainer_RefreshRequested(RefreshContainer sender, RefreshRequestedEventArgs args)
        {

        }

        private void CollegeSubjectRequestGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void CollegeSubjectRequestGridView_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
        }


        private void CollegeSubjectRequestGridView_DragOver(object sender, DragEventArgs e)
        {
        }
        private void TeachingList_DragOver(object sender, DragEventArgs e)
        {
        }
        private void TeachingList_DragEnter(object sender, DragEventArgs e)
        {
            e.DragUIOverride.IsGlyphVisible = false;
        }
        private async void TeachingList_Drop(object sender, DragEventArgs e)
        {
        }
    }
}
