using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public void RequestToken(string serviceUrl)
        {
            //TODO: info below should be encapsulated into a new class
            string clientId = "MmY0OTcwOWQzZTAzY2UzMDMyZGQzMGE4ZDk3YjEyNTdh";
            string redirectUri = "http://delivery.com";
            string state = "NY";
            string testServiceUrl = String.Format("http://sandbox.delivery.com/third_party/authorize?client_id={0}&redirect_uri={1}&response_type=code&scope=global&state={2}", clientId, redirectUri, state);
            
            
            WebRequest request = WebRequest.Create(testServiceUrl) as WebRequest;
            

            
        }

        public void SaveToken()
        {
            throw new NotImplementedException();
        }

        public void RefreshToken()
        {
            throw new NotImplementedException();
        }

        public void DeleteToken()
        {
            throw new NotImplementedException();
        }
    }
}
