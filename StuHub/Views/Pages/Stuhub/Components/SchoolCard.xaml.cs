using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace StuHub.Views.Pages.Stuhub.Components
{
    public sealed partial class SchoolCard : UserControl
    {
        public string SchooLogoUrl
        {
            get { return (string)GetValue(SchooLogoUrlProperty); }
            set { SetValue(SchooLogoUrlProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SchooLogoUrl.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SchooLogoUrlProperty =
            DependencyProperty.Register("SchooLogoUrl", typeof(string), typeof(SchoolCard), null);

        public string SchoolName
        {
            get { return (string)GetValue(SchoolNameProperty); }
            set { SetValue(SchoolNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SchoolName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SchoolNameProperty =
            DependencyProperty.Register("SchoolName", typeof(string), typeof(SchoolCard), null);

        public string City
        {
            get { return (string)GetValue(CityProperty); }
            set { SetValue(CityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for City.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CityProperty =
            DependencyProperty.Register("City", typeof(string), typeof(SchoolsDialog), null);

        public float MalePercentage
        {
            get { return (float)GetValue(MalePercentageProperty); }
            set { SetValue(MalePercentageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MalePercentage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MalePercentageProperty =
            DependencyProperty.Register("MalePercentage", typeof(float), typeof(SchoolsDialog), null);

        public float FemalePercentage
        {
            get { return (float)GetValue(FemalePercentageProperty); }
            set { SetValue(FemalePercentageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MalePercentage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FemalePercentageProperty =
            DependencyProperty.Register("MalePercentage", typeof(float), typeof(SchoolsDialog), null);
        public SchoolCard()
        {
            this.InitializeComponent();
        }
    }
}
