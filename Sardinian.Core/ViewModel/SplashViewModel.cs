using Cirrious.MvvmCross.ViewModels;
using Sardinian.Core.Services;
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
        IAuthenticationService _authenticationService;
        #endregion

        #region Commands
        private MvxCommand authenticationCommand;
        public MvxCommand AuthenticationCommand
        {
            get { return new MvxCommand(delegate { 
            
                

            }); }
        }
        
        #endregion

        #region Constructor(s)
        public SplashViewModel() { }
        #endregion
    }
}
