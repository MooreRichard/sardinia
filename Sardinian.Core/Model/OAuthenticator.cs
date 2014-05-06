using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sardinian.Core.Model
{
    /// <summary>
    /// This class will be used for authentication
    /// Users should be able to specify the Token URL as well as 
    /// authentication credentials to kick-off OAuth process.
    /// 
    /// </summary>
    public class OAuthenticator
    {
        string _serviceUrl;
        string _userName;
        string _userPassword;
        string _accessToken;

        public OAuthenticator(string serviceUrl, string userName, string password)
        {
            _serviceUrl = serviceUrl;
            _userName = userName;
            _userPassword = password;
            _accessToken = String.Empty;
        }
    }

}
