using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Delivery.Core.DTO
{
    public class Card
    {

        [JsonProperty("cc_id")]
        public string CcId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("last_four")]
        public string LastFour { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }
    }

    public class GetCreditCardResponse
    {

        [JsonProperty("message")]
        public Message[] Message { get; set; }

        [JsonProperty("cards")]
        public Card[] Cards { get; set; }
    }
}
