using Delivery.WindowsStore.Common;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using Microsoft.Practices.Unity;
using Delivery.Core.Services;
using Delivery.WindowsStore.ViewModels;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Hub App template is documented at http://go.microsoft.com/fwlink/?LinkId=321221

namespace Delivery.WindowsStore
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : MvvmAppBase
    {

        private UnityContainer _container = new UnityContainer();

        /// <summary>
        /// Initializes the singleton Application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private async void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            await SuspensionManager.SaveAsync();
            deferral.Complete();
        }

        protected override System.Threading.Tasks.Task OnLaunchApplication(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate("RestaurantsLanding", null);
            return Task.FromResult<object>(null);
        }


        protected override void OnInitialize(IActivatedEventArgs args)
        {
            //Register singleton services with container 
            _container.RegisterInstance<INavigationService>(NavigationService);
            _container.RegisterInstance<ISessionStateService>(SessionStateService);

            //Register view models with container
            _container.RegisterType<IDeliveryDataService, DeliveryDataService>();

            //Set default factory view so that dependencies are injected into view models
            ViewModelLocator.SetDefaultViewModelFactory((viewModelType) => _container.Resolve(viewModelType));

            base.OnInitialize(args);
        }
    }
}
