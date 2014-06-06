
using Delivery.Core.Services;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WindowsStore.ViewModels
{
    public class RestaurantsLandingPageViewModel : ViewModel
    {
        public IDeliveryDataService _dataService;
        public INavigationService _navigationService;

        public RestaurantsLandingPageViewModel(IDeliveryDataService dataService, INavigationService navigationService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
        }
    }
}
