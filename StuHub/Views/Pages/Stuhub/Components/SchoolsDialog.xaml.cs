using StuHub.Models.Stuhub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StuHub.Views.Pages.Stuhub.Components
{
    public sealed partial class SchoolsDialog : ContentDialog
    {
        private readonly List<School> schoolData = new List<School>();
        public SchoolsDialog()
        {
            this.InitializeComponent();

            schoolData = DemoSchoolData.GetData();
        }
        private async void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            var anim = ConnectedAnimationService.GetForCurrentView().GetAnimation("ForwardConnectedAnimation");
            if (anim != null)
            {
                anim.TryStart(SchoolLogo);
            }
            await Task.Delay(3500);
            SchoolShimmer.Opacity = 0.0;
            await Task.Delay(2000);
            SchoolGrid.Opacity = 1.0;
        }
        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }
}
