using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.DTO
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


    public class CreateLocationResponse
    {

        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }
}
