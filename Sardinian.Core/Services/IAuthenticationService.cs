using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Core.Services
{
    public interface IAuthenticationService
    {
        void RequestToken();
        void SaveToken();
        void RefreshToken();
        void DeleteToken();
    }
}
