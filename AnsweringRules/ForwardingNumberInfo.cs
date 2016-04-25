using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class ForwardingNumberInfo
    {

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
