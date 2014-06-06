using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.DTO
{
    public class Option2
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("item_key")]
        public int ItemKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class Option
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("item_key")]
        public int ItemKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("options")]
        public Option2[] Options { get; set; }
    }

    public class Vertical
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class Order
    {

        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        [JsonProperty("merchant_id")]
        public int MerchantId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("order_date")]
        public string OrderDate { get; set; }

        [JsonProperty("delivery_date")]
        public string DeliveryDate { get; set; }

        [JsonProperty("location_id")]
        public int LocationId { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("delivery_fee")]
        public int DeliveryFee { get; set; }

        [JsonProperty("tax")]
        public double Tax { get; set; }

        [JsonProperty("subtotal")]
        public double Subtotal { get; set; }

        [JsonProperty("tip")]
        public double Tip { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("gift_card_amount_used")]
        public int GiftCardAmountUsed { get; set; }

        [JsonProperty("promo_amount_used")]
        public int PromoAmountUsed { get; set; }

        [JsonProperty("points_earned")]
        public int PointsEarned { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("cart")]
        public Cart[] Cart { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("favorite_name")]
        public object FavoriteName { get; set; }

        [JsonProperty("vertical")]
        public Vertical Vertical { get; set; }
    }

    public class ViewOrderResponse
    {
        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }
    }

    public class ViewOrderHistoryResponse
    {
        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("orders")]
        public Order[] Order { get; set; }
    }

    public class ReorderResponse
    {

        [JsonProperty("message")]
        public object[] Message { get; set; }

        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty("url")]
        public Url Url { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }    
}
