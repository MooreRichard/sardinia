using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Core.ViewModel
{
    public class SplashViewModel : MvxViewModel
    {
        #region Services
        
        #endregion

        #region Commands
        private MvxCommand authenticationCommand;

        public MvxCommand AuthenticationCommand
        {
            get { return new MvxCommand(ExecuteAuthenticationCommand); }
        }

        private void ExecuteAuthenticationCommand()
        {
        }
        
        #endregion

        #region Constructor(s)
        public SplashViewModel() { }
        #endregion
    }
}
