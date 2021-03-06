using Cirrious.MvvmCross.WindowsStore.Views;
using Sardinian.Core.ViewModel;

namespace Sardinian.UI.WindowsStore.Views
{
    public sealed partial class SplashView : MvxStorePage
    {
        public new SplashViewModel ViewModel
        {
            get { return (SplashViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public SplashView()
        {
            this.InitializeComponent();
        }
    }
}
