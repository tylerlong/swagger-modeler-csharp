using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ForwardingNumbers
{
    public class ForwardingNumberInfo
    {

        [JsonProperty("features")]
        public string Features;

        [JsonProperty("flipNumber")]
        public int FlipNumber;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("label")]
        public string Label;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("uri")]
        public string Uri;

    }
}
