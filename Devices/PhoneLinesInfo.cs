using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Devices
{
    public class PhoneLinesInfo
    {

        [JsonProperty("lineType")]
        public string LineType;

        [JsonProperty("phoneInfo")]
        public PhoneNumberInfo PhoneInfo;

    }
}
