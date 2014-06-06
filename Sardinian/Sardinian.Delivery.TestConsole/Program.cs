using Delivery.Core.DTO;
using Sardinian.Delivery.Core.Services;
using Sardinian.Delivery.Core.Utility;
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
            await _dataService.GenerateGuestToken();
            await _dataService.AddItemToCart("86", new AddGuestItemRequest() { OrderType = "delivery", ClientId = Constants.ClientId, Item = new CartItem() {ItemId="N936", ItemQty=2 } });
            await _dataService.GetCartItems("86");
            await _dataService.GetMerchantInfo("86");

            await _dataService.GetMerchants("400 East 11th St New York NY 10009");
            await _dataService.GetMerchantMenu("86");
            evt.Set();
        }

    }
}
