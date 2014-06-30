using Delivery.Core.DTO;
using Delivery.Core.Services;
using Delivery.WindowsStore.Common;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Delivery.WindowsStore.ViewModels
{
    public class RestaurantItemDetailPageViewModel
    {
        #region Services
        public IDeliveryDataService _dataService;
        public INavigationService _navigationService;
        public ISessionStateService _sessionStateService;
        #endregion

        public RestaurantItemDetailPageViewModel(IDeliveryDataService dataService, INavigationService navigationService, ISessionStateService sessionStateService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
            _sessionStateService = sessionStateService;
        }

        private ICommand _initializeViewModelCommand;
        public ICommand InitializeViewModelCommand
        {
            get
            {
                return _initializeViewModelCommand ?? (_initializeViewModelCommand = new DelegateCommand(
                    async delegate
                    {
                        System.Diagnostics.Debug.WriteLine("Restaurant Detailed Item Page View Model Initializing..");
                        Child selectedItem = _sessionStateService.SessionState["SelectedItem"] as Child;
                    }));
            }
        }

        private ICommand _goBackCommand;
        public ICommand GoBackCommand
        {
            get
            {
                return _goBackCommand ?? (_goBackCommand = new DelegateCommand(delegate
                {
                    _navigationService.GoBack();
                }));
            }
            
        }
    }
}
