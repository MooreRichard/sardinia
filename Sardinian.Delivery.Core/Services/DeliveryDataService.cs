using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sardinian.Delivery.Core.DTO;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Sardinian.Delivery.Core.Utility;

namespace Sardinian.Delivery.Core.Services
{
    public class DeliveryDataService : IDeliveryDataService
    {
        private const string developmentUrl = "http://sandbox.delivery.com";
        private const string productionUrl = "https://api.delivery.com";

        public Task<CreateLocationResponse> CreateLocation(string accessToken, CreateLocationRequest requestObject)
        {
            throw new NotImplementedException();
        }

        public Task<CreateLocationResponse> UpdateLocation(string accessToken, string locationId)
        {
            throw new NotImplementedException();
        }

        public Task<CreateLocationResponse> DeleteLocation(string accessToken, string locationId)
        {
            throw new NotImplementedException();
        }

        public Task<CreateLocationResponse> GetLocations(string accessToken)
        {
            throw new NotImplementedException();
        }

        public Task<AddItemResponse> AddItemToCart(string merchantId, AddItemRequest requestObject)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyItemResponse> ModifyCartItem(string merchantId, ModifyItemRequest requestObject)
        {
            throw new NotImplementedException();
        }

        public Task<GetContentsResponse> GetCartItems(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<AddItemResponse> ClearCart(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<AddItemResponse> RemoveCartItem(string merchantId, string item_key)
        {
            throw new NotImplementedException();
        }

        public Task<string> GenerateGuestToken()
        {
            throw new NotImplementedException();
        }

        public Task<GetPaymentsResponse> GetPayments(string accessToken, string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<PlaceOrderResponse> PlaceOrder(string merchantId, PlaceOrderRequest requestObject)
        {
            throw new NotImplementedException();
        }

        public Task<ViewOrderResponse> GetOrder(string accessToken, string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<ViewOrderHistoryResponse> GetOrderHistory(string accessToken)
        {
            throw new NotImplementedException();
        }

        public Task<ReorderResponse> Reorder(string accessToken, string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<GetCreditCardResponse> GetAvailableCreditCards(string accesToken, bool includeExpiredCards = true)
        {
            throw new NotImplementedException();
        }

        public Task<GetMerchantHoursResponse> GetBusinessAndDeliveryHours(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<GetMerchantInfoResponse> GetBusinessInfo(string merchantId)
        {
            throw new NotImplementedException();
        }

        public Task<GetMerchantMenuResponse> GetBusinessMenu(string merchantId)
        {
            throw new NotImplementedException();
        }

        public void GetMenuItem(string merchantId, string itemId)
        {
            throw new NotImplementedException();
        }

        public void GetAllBusinesses(string method = "delivery")
        {
            string serviceUrl = string.Format("{0}{1}{2}", productionUrl, Constants.MerchantSearch, method+"?address=400 East 11th St, New York, NY, 10009");
            MakeGetRequest(null, serviceUrl);
        }

        #region Private Helpers
        private async void MakeGetRequest(string accessToken, string serviceUrl)
        {
            HttpWebRequest req = WebRequest.Create(serviceUrl) as HttpWebRequest;
            
            string result = null;
            using (HttpWebResponse resp = await req.GetResponseAsync() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }
        }
        private async void MakePostRequesst(string accessToken, string serviceUrl, string data)
        {
            HttpWebRequest req = WebRequest.Create(new Uri(serviceUrl)) as HttpWebRequest;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            // Encode the parameters as form data:
            byte[] formData = UTF8Encoding.UTF8.GetBytes(data);

            // Send the request:
            using (Stream post = await req.GetRequestStreamAsync())
            {
                post.Write(formData, 0, formData.Length);
            }

            // Pick up the response:
            string result = "";
            using (HttpWebResponse resp = await req.GetResponseAsync()as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }
        }
        #endregion
    }
}
