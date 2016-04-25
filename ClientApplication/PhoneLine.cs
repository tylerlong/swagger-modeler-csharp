using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class PhoneLine
    {

        [JsonProperty("lineType")]
        public string LineType;

        [JsonProperty("enabled")]
        public boolean Enabled;

        [JsonProperty("phoneInfo")]
        public PhoneNumberInfo PhoneInfo;

    }
}
