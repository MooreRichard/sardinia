using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Delivery.Core.DTO
{
    public class Cash
    {
        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class Promo
    {

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reward")]
        public string Reward { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreditCard
    {

        [JsonProperty("last_four")]
        public string LastFour { get; set; }

        [JsonProperty("cc_type")]
        public string CcType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreditBalance
    {

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class PaymentMethods
    {

        [JsonProperty("cash")]
        public Cash Cash { get; set; }

        [JsonProperty("promo")]
        public Promo[] Promo { get; set; }

        [JsonProperty("credit_card")]
        public CreditCard[] CreditCard { get; set; }

        [JsonProperty("credit_balance")]
        public CreditBalance[] CreditBalance { get; set; }
    }

    public class GetPaymentsResponse
    {

        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("payment_methods")]
        public PaymentMethods PaymentMethods { get; set; }
    }

    public class Payment
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class PlaceOrderRequest
    {

        [JsonProperty("tip")]
        public double Tip { get; set; }

        [JsonProperty("location_id")]
        public int LocationId { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("payments")]
        public Payment[] Payments { get; set; }

        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        [JsonProperty("order_time")]
        public string OrderTime { get; set; }
    }
    
    public class PlaceOrderResponse
    {

        [JsonProperty("message")]
        public Message[] Message { get; set; }
    }
}

    


