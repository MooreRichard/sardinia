using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Delivery.Core.DTO
{
    public class GuestTokenRequest
    {
        [JsonProperty("key")]
        public string ClientId { get; set; }
    }
}
