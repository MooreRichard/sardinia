using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Delivery.Core.DTO
{

    public class OptionQty
    {
        [JsonProperty("N17")]
        public int N17 { get; set; }
    }

    public class Item
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("children")]
        public Child[] Children { get; set; }
    }


    public class CartItem
    {

        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("item_qty")]
        public int ItemQty { get; set; }
    }

    public class AddGuestItemRequest
    {

        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        [JsonProperty("item")]
        public CartItem Item { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }
    }

    
    public class ModifyGuestItemRequest
    {

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        [JsonProperty("order_time")]
        public string OrderTime { get; set; }
    }

    public class ClearCartItemRequest
    {

        [JsonProperty("cart_index")]
        public int CartIndex { get; set; }
    }

    public class AddItemResponse
    {

        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("tax")]
        public double Tax { get; set; }

        [JsonProperty("item_key")]
        public int ItemKey { get; set; }

        [JsonProperty("item_count")]
        public int ItemCount { get; set; }

        [JsonProperty("order_time")]
        public string OrderTime { get; set; }
    }

    public class ModifyItemResponse
    {

        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("tax")]
        public double Tax { get; set; }

        [JsonProperty("item_key")]
        public int ItemKey { get; set; }

        [JsonProperty("item_count")]
        public int ItemCount { get; set; }

        [JsonProperty("order_time")]
        public string OrderTime { get; set; }
    }

    public class Cart
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("item_key")]
        public int ItemKey { get; set; }
    }

    public class GetContentsResponse
    {
        [JsonProperty("cart")]
        public Cart[] Cart { get; set; }

        [JsonProperty("item_count")]
        public int ItemCount { get; set; }

        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("tax")]
        public double Tax { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("fees")]
        public object[] Fees { get; set; }

        [JsonProperty("order_time")]
        public string OrderTime { get; set; }

        [JsonProperty("asap")]
        public bool Asap { get; set; }

        [JsonProperty("order_type")]
        public string OrderType { get; set; }
    }
}
