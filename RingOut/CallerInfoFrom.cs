using Newtonsoft.Json;
using System;

namespace RingCentral.Models.RingOut
{
    public class CallerInfoFrom
    {

        [JsonProperty("forwardingNumberId")]
        public string ForwardingNumberId;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

    }
}
