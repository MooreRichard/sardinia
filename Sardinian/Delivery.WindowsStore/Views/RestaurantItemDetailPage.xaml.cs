using Delivery.Core.DTO;
using Delivery.WindowsStore.Common;
using Delivery.WindowsStore.ViewModels;
using Microsoft.Practices.Prism.StoreApps;
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

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Delivery.WindowsStore.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class RestaurantItemDetailPage : VisualStateAwarePage
    {
        private RestaurantItemDetailPageViewModel ViewModel
        {
            get { return DataContext as RestaurantItemDetailPageViewModel; }
        }
        public RestaurantItemDetailPage()
        {
            this.InitializeComponent();
            this.Loaded += RestaurantItemDetailPage_Loaded;
        }

        void RestaurantItemDetailPage_Loaded(object sender, RoutedEventArgs e)
        {
            
            ViewModel.InitializeViewModelCommand.Execute(null);
        }

    }
}
