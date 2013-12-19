using Cirrious.MvvmCross.WindowsStore.Views;
using Sardinian.Core.ViewModel;

namespace Sardinian.UI.WindowsStore.Views
{
    public sealed partial class HomeView : MvxStorePage
    {
        public new HomeViewModel ViewModel
        {
            get { return (HomeViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public HomeView()
        {
            this.InitializeComponent();
        }
    }
}
