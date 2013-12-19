using Sardinian.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.CrossCore.IoC;

namespace Sardinian.Core
{
    public class SardinianApp : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public SardinianApp()
        {
            InitaliseServices();
            InitialiseStartNavigation();
            InitialisePlugIns();
        }


        private void InitaliseServices()
        {
            CreatableTypes()
                .EndingWith("SearchProvider")
                .AsInterfaces()
                .RegisterAsSingleton();
        }


        private void InitialiseStartNavigation()
        {
            RegisterAppStart<SplashViewModel>();
        }


        private void InitialisePlugIns()
        {
            //Cirrious.MvvmCross.Plugins.Visibility.PluginLoader.Instance.EnsureLoaded();
        }

    }

}
