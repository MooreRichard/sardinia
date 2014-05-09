using Sardinian.Delivery.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sardinian.Delivery.TestConsole
{
    class Program
    {
        static DeliveryDataService _dataService = new DeliveryDataService();
        static AutoResetEvent evt = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            RunTests();
            evt.WaitOne();
        }

        private static async void RunTests()
        {
            await _dataService.GetMerchantInfo("86");
            await _dataService.GetMerchantMenuItem("86", "N923");
            await _dataService.GetMerchants("400 East 11th St New York NY 10009"); 
            await _dataService.GetMerchantMenu("86");
            evt.Set();
        }

    }
}
