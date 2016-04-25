using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ForwardingNumbers
{
    public class UpdateForwardingNumberRequest
    {

        [JsonProperty("flipNumber")]
        public string FlipNumber;

        [JsonProperty("label")]
        public string Label;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

    }
}
