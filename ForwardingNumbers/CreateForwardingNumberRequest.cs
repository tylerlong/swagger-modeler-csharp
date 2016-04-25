using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ForwardingNumbers
{
    public class CreateForwardingNumberRequest
    {

        [JsonProperty("label")]
        public string Label;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

    }
}
