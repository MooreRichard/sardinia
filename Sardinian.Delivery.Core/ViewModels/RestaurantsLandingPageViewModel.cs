
using Delivery.Core.Services;
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

        public RestaurantsLandingPageViewModel(IDeliveryDataService dataService)
        {
            _dataService = dataService;
            System.Diagnostics.Debug.WriteLine("Constructor invoked.");
        }
    }
}
