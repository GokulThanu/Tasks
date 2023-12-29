using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Profile;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SpaceFlightNewsAPI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Main_Page : Page
    {
        bool isDeskTop=false;
        public Main_Page()
        {
            this.InitializeComponent();
            this.Loaded += Main_Page_Loaded;
            this.DataContext = new ViewModel();
        }

        private void Main_Page_Loaded(object sender, RoutedEventArgs e)
        {

            string deviceFamily = AnalyticsInfo.VersionInfo.DeviceFamily;
            isDeskTop = deviceFamily == "Windows.Desktop";
            if(!isDeskTop)
            {
                VisualStateManager.GoToState(this, "TabletMode", true);
            }
            else
            {
                apiListView.SelectedIndex = 0;
                VisualStateManager.GoToState(this, "DesktopMode", true);
                apiDescriptionTextBlock.Width = this.ActualWidth / 2;
            }

        }

       

        private void apiListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(isDeskTop)
            {
                apiDescriptionTextBlock.Text = (apiListView.SelectedItem as Model).Description;
            }
            else
            {
                DescriptionPage description=new DescriptionPage();
                Frame.Navigate(typeof(DescriptionPage),this);
            }
            
        }
    }
}
