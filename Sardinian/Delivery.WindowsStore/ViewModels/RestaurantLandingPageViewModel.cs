﻿
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
    public class RestaurantLandingPageViewModel : ViewModel, INotifyPropertyChanged
    {
        #region Services
        public IDeliveryDataService _dataService;
        public INavigationService _navigationService;
        public ISessionStateService _sessionStateService;
        #endregion

        #region Databinding Properties
        private Merchant _currentMerchant;
        public Merchant CurrentMerchant
        {
            get { return _currentMerchant; }
            set { SetProperty(ref _currentMerchant,  value); }
        }

        private Menu _selectedSubCategory;

        public Menu SelectedSubCategory
        {
            get { return _selectedSubCategory; }
            set
            {
                SetProperty(ref _selectedSubCategory, value);
            }
        }

        private ObservableCollection<Menu> _merchantMenu;
        public ObservableCollection<Menu> MerchantMenu
        {
            get { return _merchantMenu; }
            set { SetProperty(ref _merchantMenu, value); }
        }
        #endregion

        public RestaurantLandingPageViewModel(IDeliveryDataService dataService, INavigationService navigationService, ISessionStateService sessionStateService)
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
                        System.Diagnostics.Debug.WriteLine("Restaurant Landing Page View Model Initializing..");
                        CurrentMerchant = _sessionStateService.SessionState["CurrentMerchant"] as Merchant;
                        var result = await _dataService.GetMerchantMenu(CurrentMerchant.Id);
                        if (result == null)
                            return;
                        MerchantMenu = result.Menu;
                        SelectedSubCategory = MerchantMenu[0];
                        System.Diagnostics.Debug.WriteLine(result.Menu[0].Name);
                    }));
            }
        }

        private ICommand _navigateBackCommand;
        public ICommand NavigateBackCommand
        {
            get
            {
                return _navigateBackCommand ?? (_navigateBackCommand = new RelayCommand(delegate()
                    {
                        _navigationService.GoBack();
                    }));
            }
        }

        private ICommand _navigateToSelectedRestaurantCommand;
        public ICommand NavigateToSelectedRestaurantCommand
        {
            get
            {
                return _navigateToSelectedRestaurantCommand ?? (_navigateToSelectedRestaurantCommand = new DelegateCommand<Child>(async delegate(Child selectedItem)
                {
                    _sessionStateService.SessionState["SelectedItem"] = selectedItem;
                    _navigationService.Navigate("RestaurantItemDetail", null);
                }));
            }
        }

        #endregion
    }
}
