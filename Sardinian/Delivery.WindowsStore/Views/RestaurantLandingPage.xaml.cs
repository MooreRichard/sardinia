using Delivery.Core.DTO;
using Delivery.WindowsStore.ViewModels;
using Microsoft.Practices.Prism.StoreApps;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Delivery.WindowsStore.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class RestaurantLandingPage : VisualStateAwarePage
    {
        public RestaurantLandingPageViewModel ViewModel { get { return DataContext as RestaurantLandingPageViewModel; } }
        
        public RestaurantLandingPage()
        {
            this.InitializeComponent();
            this.Loaded += RestaurantLandingPage_Loaded;
        }

        void RestaurantLandingPage_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.InitializeViewModelCommand.Execute(null);
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //6ViewModel.NavigateToSelectedRestaurantCommand.Execute(e.ClickedItem);
            ShoppingCart.Groups = (e.ClickedItem as Child).Customizations;
        }
    }
}
