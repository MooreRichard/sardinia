﻿using Delivery.Core.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Services
{
    public interface IDeliveryDataService
    {
        Merchant CurrentMerchant { get; set; }

        Task<CreateLocationResponse> CreateLocation(string accessToken, CreateLocationRequest requestObject);

        Task<CreateLocationResponse> UpdateLocation(string accessToken, string locationId);

        Task<CreateLocationResponse> DeleteLocation(string accessToken, string locationId);

        Task<CreateLocationResponse> GetLocations(string accessToken);

        Task<AddItemResponse> AddItemToCart(string merchantId, AddGuestItemRequest requestObject);

        Task<ModifyItemResponse> ModifyCartItem(string merchantId, ModifyGuestItemRequest requestObject);

        Task<GetContentsResponse> GetCartItems(string merchantId);

        Task<AddItemResponse> ClearCart(string merchantId, ClearGuestCartItemRequest requestObject);

        Task<AddItemResponse> RemoveCartItem(string merchantId, RemoveGuestCartItemRequest requestObject);


        Task<string> GenerateGuestToken();

        Task<GetPaymentsResponse> GetPayments(string accessToken, string merchantId);

        Task<PlaceOrderResponse> PlaceOrder(string merchantId, PlaceOrderRequest requestObject);

        Task<ViewOrderResponse> GetOrder(string accessToken, string orderId);

        Task<ViewOrderHistoryResponse> GetOrderHistory(string accessToken);

        Task<ReorderResponse> Reorder(string accessToken, string orderId);

        Task<GetCreditCardResponse> GetAvailableCreditCards(string accesToken, bool includeExpiredCards = true);

        Task<GetMerchantHoursResponse> GetMerchantHours(string merchantId);

        Task<GetMerchantInfoResponse> GetMerchantInfo(string merchantId);

        Task<GetMerchantMenuResponse> GetMerchantMenu(string merchantId);

        Task<GetMerchantMenuItemResponse> GetMerchantMenuItem(string merchantId, string itemId);

        Task<ObservableCollection<Merchant>> GetMerchants(string userAddress, string method = "delivery");
    }
}
