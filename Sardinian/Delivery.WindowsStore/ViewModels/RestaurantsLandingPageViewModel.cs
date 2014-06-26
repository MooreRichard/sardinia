
using Delivery.Core.DTO;
using Delivery.Core.Services;
using Delivery.WindowsStore.Common;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Delivery.WindowsStore.ViewModels
{
    public class RestaurantsLandingPageViewModel : ViewModel, INotifyPropertyChanged
    {
        #region Services
        public IDeliveryDataService _dataService;
        public INavigationService _navigationService;
        public ISessionStateService _sessionStateService;
        #endregion

        #region Databinding Properties
        private Merchant _selectedMerchant;
        public Merchant SelectedMerchant
        {
            get { return _selectedMerchant; }
            set
            {
                SetProperty(ref _selectedMerchant, value);
            }
        }

        private ObservableCollection<Merchant> _merchants;
        public ObservableCollection<Merchant> Merchants
        {
            get { return _merchants; }
            set
            {
                SetProperty(ref _merchants, value);
            }
        }

        #endregion

        public RestaurantsLandingPageViewModel(IDeliveryDataService dataService, INavigationService navigationService, ISessionStateService sessionStateService)
        {
            _dataService = dataService;
            _navigationService = navigationService;
            _sessionStateService = sessionStateService;
        }

        #region Commands

        private ICommand _initializeViewModelCommand;
        public ICommand InitializeViewModelCommand
        {
            get
            {
                return _initializeViewModelCommand ?? (_initializeViewModelCommand = new RelayCommand(
                    async delegate
                    {
                        await _dataService.GenerateGuestToken();
                        Merchants = await _dataService.GetMerchants("400 East 11th St New York NY 10009");
                    }));
            }
        }

        private ICommand _navigateToSelectedRestaurantCommand;
        public ICommand NavigateToSelectedRestaurantCommand
        {
            get
            {
                return _navigateToSelectedRestaurantCommand ?? (_navigateToSelectedRestaurantCommand = new DelegateCommand<Merchant>(async delegate (Merchant currentMerchant)
                    {
                        _sessionStateService.SessionState["CurrentMerchant"] = currentMerchant;
                        _navigationService.Navigate("RestaurantLanding", _selectedMerchant);
                       
                    }));
            }
        }

        #endregion
    }
}
