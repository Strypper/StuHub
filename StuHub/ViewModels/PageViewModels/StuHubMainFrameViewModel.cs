using StuHub.Models.Stuhub;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace StuHub.ViewModels.PageViewModels
{
    public class StuHubMainFrameViewModel : BaseViewModel
    {
        public ObservableCollection<SchoolStory> Stories { get; set; }
        public List<Club> Clubs { get; set; }
        public StuHubMainFrameViewModel()
        {
            Stories = DemoSchoolStoryData.GetData();
            Clubs = DemoClubData.GetData();
        }
    }
}
