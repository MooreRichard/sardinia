using Delivery.WindowsStore.ViewModels;
using Microsoft.Practices.Prism.StoreApps;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Delivery.WindowsStore.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class RestaurantsLandingPage : VisualStateAwarePage
    {

        public RestaurantsLandingPageViewModel ViewModel { get { return DataContext as RestaurantsLandingPageViewModel; } }
     
        public RestaurantsLandingPage()
        {
            this.InitializeComponent();
            this.Loaded += RestaurantsLandingPage_Loaded;
        }

        void RestaurantsLandingPage_Loaded(object sender, RoutedEventArgs e)
        {
            (DataContext as RestaurantsLandingPageViewModel).InitializeViewModelCommand.Execute(null);
        }

        private void gvMerchants_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewModel.NavigateToSelectedRestaurantCommand.Execute(e.ClickedItem);
        }

        private void SearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            ViewModel.MerchantSearchCommand.Execute(args.QueryText);
        }
    }
}
