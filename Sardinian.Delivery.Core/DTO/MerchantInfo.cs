using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Delivery.Core.DTO
{
    public class Summary
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("overall_rating")]
        public int OverallRating { get; set; }

        [JsonProperty("num_ratings")]
        public int NumRatings { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("cuisines")]
        public string[] Cuisines { get; set; }

        [JsonProperty("url")]
        public Url Url { get; set; }

        [JsonProperty("activation_date")]
        public string ActivationDate { get; set; }
    }

    public class Ordering
    {

        [JsonProperty("availability")]
        public Availability Availability { get; set; }

        [JsonProperty("payment_types")]
        public string[] PaymentTypes { get; set; }

        [JsonProperty("time_needed")]
        public string TimeNeeded { get; set; }

        [JsonProperty("specials")]
        public string[] Specials { get; set; }

        [JsonProperty("order_type")]
        public string OrderType { get; set; }
    }

    public class Minimum
    {

        [JsonProperty("delivery")]
        public Delivery Delivery { get; set; }

        [JsonProperty("pickup")]
        public int Pickup { get; set; }
    }

    public class Merchant
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        [JsonProperty("ordering")]
        public Ordering Ordering { get; set; }

        [JsonProperty("minimum")]
        public Minimum Minimum { get; set; }
    }

    public class GetMerchantInfoResponse
    {

        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("merchant")]
        public Merchant Merchant { get; set; }
    }

}
