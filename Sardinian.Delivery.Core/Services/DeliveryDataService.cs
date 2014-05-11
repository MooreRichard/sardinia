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
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

namespace Sardinian.Delivery.Core.Services
{
    public class DeliveryDataService : IDeliveryDataService
    {
        private const string developmentUrl = "http://sandbox.delivery.com";
        private const string productionUrl = "https://api.delivery.com";
        private string _guestToken = "";

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

        #region Guest Authentication
        public async Task<string> GenerateGuestToken()
        {
            string serviceUrl = string.Format("{0}{1}?client_id={2}", productionUrl, Constants.GuestTokenEndpoint, Constants.ClientId);
            try
            {
                var result = await MakeGetRequest(null, serviceUrl);
                _guestToken = result["Guest-Token"].ToString();
            }
            catch
            {

            }

            return _guestToken;
        }
        #endregion

        #region Cart Related Services
        public async Task<AddItemResponse> AddItemToCart(string merchantId, AddGuestItemRequest requestObject)
        {
            string serviceUrl = string.Format("{0}{1}{2}?client_id={3}", productionUrl, Constants.GetCartItemsEndpoint, merchantId, Constants.ClientId);
            try
            {
                string data = JsonConvert.SerializeObject(requestObject);
                await MakePostRequest(null, serviceUrl, data);
                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<ModifyItemResponse> ModifyCartItem(string merchantId, ModifyGuestItemRequest requestObject)
        {
            string serviceUrl = string.Format("{0}{1}{2}?client_id={3}", productionUrl, Constants.GetCartItemsEndpoint, merchantId, Constants.ClientId);
            try
            {
                string data = JsonConvert.SerializeObject(requestObject);
                await MakePutRequest(null, serviceUrl, data);
                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<GetContentsResponse> GetCartItems(string merchantId)
        {
            string serviceUrl = string.Format("{0}{1}{2}?client_id={3}", productionUrl, Constants.GetCartItemsEndpoint, merchantId, Constants.ClientId);
            try
            {
                JObject retVal = await MakeGetRequest(null, serviceUrl);
                var info = JsonConvert.DeserializeObject<GetContentsResponse>(retVal.ToString());
                return info;
            }
            catch
            {
                return null;
            }
        }

        public async Task<AddItemResponse> ClearCart(string merchantId, ClearGuestCartItemRequest requestObject)
        {
            string serviceUrl = string.Format("{0}{1}{2}?client_id={3}", productionUrl, Constants.GetCartItemsEndpoint, merchantId, Constants.ClientId);
            try
            {
                string data = JsonConvert.SerializeObject(requestObject);
                await MakeDeleteRequest(null, serviceUrl, data);
                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<AddItemResponse> RemoveCartItem(string merchantId, RemoveGuestCartItemRequest requestObject)
        {
            string serviceUrl = string.Format("{0}{1}{2}?client_id={3}", productionUrl, Constants.GetCartItemsEndpoint, merchantId, Constants.ClientId);
            try
            {
                string data = JsonConvert.SerializeObject(requestObject);
                await MakeDeleteRequest(null, serviceUrl, data);
                return null;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Merchant and Menu Related Servies

        public async Task<GetMerchantInfoResponse> GetMerchantInfo(string merchantId)
        {
            //GET /merchant/{merchant_id}/menu
            string serviceUrl = string.Format("{0}{1}{2}?client_id={3}", productionUrl, Constants.MerchantMenuEndpoint, merchantId, Constants.ClientId);
            try
            {
                JObject retVal = await MakeGetRequest(null, serviceUrl);
                var info = JsonConvert.DeserializeObject<GetMerchantInfoResponse>(retVal.ToString());
                return info;
            }
            catch
            {
                return null;
            }
        }

        public async Task<GetMerchantMenuItemResponse> GetMerchantMenuItem(string merchantId, string itemId)
        {
            //GET /merchant/{merchant_id}/menu/{item_id}
            string serviceUrl = string.Format("{0}{1}{2}/menu/{3}?client_id={4}", productionUrl, Constants.MerchantMenuEndpoint, merchantId, itemId, Constants.ClientId);
            try
            {
                JObject retVal = await MakeGetRequest(null, serviceUrl);
                var merchantMenuItem = JsonConvert.DeserializeObject<GetMerchantMenuItemResponse>(retVal.ToString());
                return merchantMenuItem;
            }
            catch
            {
                return null;
            }
        }

        public async Task<GetMerchantMenuResponse> GetMerchantMenu(string merchantId)
        {
            //GET /merchant/{merchant_id}/
            string serviceUrl = string.Format("{0}{1}{2}/menu?client_id={3}", productionUrl, Constants.MerchantMenuEndpoint, merchantId, Constants.ClientId);
            try
            {
                JObject retVal = await MakeGetRequest(null, serviceUrl);
                var merchantMenu = JsonConvert.DeserializeObject<GetMerchantMenuResponse>(retVal.ToString());
                return merchantMenu;
            }
            catch
            {
                return null;
            }
        }

        public async Task<ObservableCollection<Merchant>> GetMerchants(string userAddress, string method = "delivery")
        {
            ObservableCollection<Merchant> returnedMerchants = new ObservableCollection<Merchant>();
            userAddress = userAddress.Replace(',',' ');
            string address = "address="+WebUtility.UrlEncode(userAddress);
            string serviceUrl = string.Format("{0}{1}{2}?client_id={3}&{4}", productionUrl, Constants.MerchantSearchEndpoint, method, Constants.ClientId, address);

            try
            {
                JObject retVal = await MakeGetRequest(null, serviceUrl);
                var merchants = retVal["merchants"].Children().ToList();
                foreach (var merchant in merchants)
                {
                    try
                    {
                        Merchant business = JsonConvert.DeserializeObject<Merchant>(merchant.ToString());
                        returnedMerchants.Add(business);
                    }
                    catch (JsonReaderException) 
                    { 
                        //TODO: Ignoring malformed JSON for now..
                    }
                }
                return returnedMerchants;
            }
            catch
            {
                //TODO: Rethrow for now
                throw;
            }
        }

        #endregion

        #region Private Helpers
        private async Task<JObject> MakeGetRequest(string accessToken, string serviceUrl, bool guestMode = true)
        {
            HttpWebRequest req = WebRequest.Create(serviceUrl) as HttpWebRequest;
            
            if(!String.IsNullOrEmpty(_guestToken))
                req.Headers["Guest-Token"] = _guestToken;

            if (!string.IsNullOrEmpty(accessToken))
                req.Headers["Authoriztion"] = accessToken;

            req.Method = "GET";
            JObject jsonResult = null;
           
            using (HttpWebResponse resp = await req.GetResponseAsync() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(resp.GetResponseStream());
                string result = reader.ReadToEnd();
                jsonResult = JObject.Parse(result);
            }
            return jsonResult;
        }
        private async Task MakePostRequest(string accessToken, string serviceUrl, string data)
        {
            HttpWebRequest req = WebRequest.Create(new Uri(serviceUrl)) as HttpWebRequest;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            if (!String.IsNullOrEmpty(_guestToken))
                req.Headers["Guest-Token"] = _guestToken;

            if (!string.IsNullOrEmpty(accessToken))
                req.Headers["Authoriztion"] = accessToken;

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
        private async Task MakePutRequest(string accessToken, string serviceUrl, string data)
        {
            HttpWebRequest req = WebRequest.Create(new Uri(serviceUrl)) as HttpWebRequest;
            req.Method = "PUT";
            req.ContentType = "application/x-www-form-urlencoded";

            if (!String.IsNullOrEmpty(_guestToken))
                req.Headers["Guest-Token"] = _guestToken;

            if (!string.IsNullOrEmpty(accessToken))
                req.Headers["Authoriztion"] = accessToken;

            // Encode the parameters as form data:
            byte[] formData = UTF8Encoding.UTF8.GetBytes(data);

            // Send the request:
            using (Stream post = await req.GetRequestStreamAsync())
            {
                post.Write(formData, 0, formData.Length);
            }

            // Pick up the response:
            string result = "";
            using (HttpWebResponse resp = await req.GetResponseAsync() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }
        }
        private async Task MakeDeleteRequest(string accessToken, string serviceUrl, string data)
        {
            HttpWebRequest req = WebRequest.Create(new Uri(serviceUrl)) as HttpWebRequest;
            req.Method = "DELETE";
            req.ContentType = "application/x-www-form-urlencoded";

            if (!String.IsNullOrEmpty(_guestToken))
                req.Headers["Guest-Token"] = _guestToken;

            if (!string.IsNullOrEmpty(accessToken))
                req.Headers["Authoriztion"] = accessToken;

            // Encode the parameters as form data:
            byte[] formData = UTF8Encoding.UTF8.GetBytes(data);

            // Send the request:
            using (Stream post = await req.GetRequestStreamAsync())
            {
                post.Write(formData, 0, formData.Length);
            }

            // Pick up the response:
            string result = "";
            using (HttpWebResponse resp = await req.GetResponseAsync() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }
        }
        #endregion
    }
}
