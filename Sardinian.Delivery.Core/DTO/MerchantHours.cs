using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sardinian.Delivery.Core.DTO
{
    public class TimesOpen
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Sunday
    {

        [JsonProperty("times_open")]
        public TimesOpen[] TimesOpen { get; set; }
    }

    public class TimesOpen2
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Monday
    {

        [JsonProperty("times_open")]
        public TimesOpen2[] TimesOpen { get; set; }
    }

    public class TimesOpen3
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Tuesday
    {

        [JsonProperty("times_open")]
        public TimesOpen3[] TimesOpen { get; set; }
    }

    public class TimesOpen4
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Wednesday
    {

        [JsonProperty("times_open")]
        public TimesOpen4[] TimesOpen { get; set; }
    }

    public class TimesOpen5
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Thursday
    {

        [JsonProperty("times_open")]
        public TimesOpen5[] TimesOpen { get; set; }
    }

    public class TimesOpen6
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Friday
    {

        [JsonProperty("times_open")]
        public TimesOpen6[] TimesOpen { get; set; }
    }

    public class TimesOpen7
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Saturday
    {

        [JsonProperty("times_open")]
        public TimesOpen7[] TimesOpen { get; set; }
    }

    public class Business
    {

        [JsonProperty("sunday")]
        public Sunday Sunday { get; set; }

        [JsonProperty("monday")]
        public Monday Monday { get; set; }

        [JsonProperty("tuesday")]
        public Tuesday Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public Wednesday Wednesday { get; set; }

        [JsonProperty("thursday")]
        public Thursday Thursday { get; set; }

        [JsonProperty("friday")]
        public Friday Friday { get; set; }

        [JsonProperty("saturday")]
        public Saturday Saturday { get; set; }
    }

    public class TimesOpen8
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Sunday2
    {

        [JsonProperty("times_open")]
        public TimesOpen8[] TimesOpen { get; set; }
    }

    public class Monday2
    {

        [JsonProperty("times_open")]
        public object[] TimesOpen { get; set; }
    }

    public class TimesOpen9
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Tuesday2
    {

        [JsonProperty("times_open")]
        public TimesOpen9[] TimesOpen { get; set; }
    }

    public class TimesOpen10
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Wednesday2
    {

        [JsonProperty("times_open")]
        public TimesOpen10[] TimesOpen { get; set; }
    }

    public class TimesOpen11
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Thursday2
    {

        [JsonProperty("times_open")]
        public TimesOpen11[] TimesOpen { get; set; }
    }

    public class TimesOpen12
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Friday2
    {

        [JsonProperty("times_open")]
        public TimesOpen12[] TimesOpen { get; set; }
    }

    public class TimesOpen13
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Saturday2
    {

        [JsonProperty("times_open")]
        public TimesOpen13[] TimesOpen { get; set; }
    }

    public class StandardSchedule
    {

        [JsonProperty("business")]
        public Business Business { get; set; }

        [JsonProperty("delivery")]
        public Delivery Delivery { get; set; }
    }

    public class TimesOpen14
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Thursday3
    {

        [JsonProperty("times_open")]
        public TimesOpen14[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class Friday3
    {

        [JsonProperty("times_open")]
        public object[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class TimesOpen15
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Saturday3
    {

        [JsonProperty("times_open")]
        public TimesOpen15[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class TimesOpen16
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Sunday3
    {

        [JsonProperty("times_open")]
        public TimesOpen16[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class TimesOpen17
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Monday3
    {

        [JsonProperty("times_open")]
        public TimesOpen17[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class TimesOpen18
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Tuesday3
    {

        [JsonProperty("times_open")]
        public TimesOpen18[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class TimesOpen19
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Wednesday3
    {

        [JsonProperty("times_open")]
        public TimesOpen19[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class Business2
    {

        [JsonProperty("thursday")]
        public Thursday3 Thursday { get; set; }

        [JsonProperty("friday")]
        public Friday3 Friday { get; set; }

        [JsonProperty("saturday")]
        public Saturday3 Saturday { get; set; }

        [JsonProperty("sunday")]
        public Sunday3 Sunday { get; set; }

        [JsonProperty("monday")]
        public Monday3 Monday { get; set; }

        [JsonProperty("tuesday")]
        public Tuesday3 Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public Wednesday3 Wednesday { get; set; }
    }

    public class TimesOpen20
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Thursday4
    {

        [JsonProperty("times_open")]
        public TimesOpen20[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class Friday4
    {

        [JsonProperty("times_open")]
        public object[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class TimesOpen21
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Saturday4
    {

        [JsonProperty("times_open")]
        public TimesOpen21[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class TimesOpen22
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Sunday4
    {

        [JsonProperty("times_open")]
        public TimesOpen22[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class Monday4
    {

        [JsonProperty("times_open")]
        public object[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class TimesOpen23
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Tuesday4
    {

        [JsonProperty("times_open")]
        public TimesOpen23[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class TimesOpen24
    {

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Wednesday4
    {

        [JsonProperty("times_open")]
        public TimesOpen24[] TimesOpen { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class Delivery2
    {

        [JsonProperty("thursday")]
        public Thursday4 Thursday { get; set; }

        [JsonProperty("friday")]
        public Friday4 Friday { get; set; }

        [JsonProperty("saturday")]
        public Saturday4 Saturday { get; set; }

        [JsonProperty("sunday")]
        public Sunday4 Sunday { get; set; }

        [JsonProperty("monday")]
        public Monday4 Monday { get; set; }

        [JsonProperty("tuesday")]
        public Tuesday4 Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public Wednesday4 Wednesday { get; set; }
    }

    public class CurrentSchedule
    {

        [JsonProperty("business")]
        public Business2 Business { get; set; }

        [JsonProperty("delivery")]
        public Delivery2 Delivery { get; set; }

        [JsonProperty("availability")]
        public Availability Availability { get; set; }
    }

    public class GetMerchantHoursResponse
    {

        [JsonProperty("message")]
        public object[] Message { get; set; }

        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        [JsonProperty("standard_schedule")]
        public StandardSchedule StandardSchedule { get; set; }

        [JsonProperty("current_schedule")]
        public CurrentSchedule CurrentSchedule { get; set; }
    }
}
