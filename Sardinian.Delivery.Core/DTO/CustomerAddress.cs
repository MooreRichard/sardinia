using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Delivery.Core.DTO
{
    public class CreateLocationRequest
    {
        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        [JsonProperty("instructions")]
        public string OrderInstructions { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

    }

    public class Message
    {

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("delivery_points")]
        public int DeliveryPoints { get; set; }

        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        [JsonProperty("user_msg")]
        public string UserMsg { get; set; }

        [JsonProperty("dev_msg")]
        public string DevMsg { get; set; }
    }

    public class Location
    {

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zipcode { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("cross_streets")]
        public string CrossStreets { get; set; }

        [JsonProperty("landmark")]
        public string Landmark { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }

        [JsonProperty("unit_number")]
        public string UnitNumber { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }
    }

    public class CreateLocationResponse
    {

        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }
}
