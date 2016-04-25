using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Devices
{
    public class ShippingInfo
    {

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("carrier")]
        public string Carrier;

        [JsonProperty("trackingNumber")]
        public string TrackingNumber;

        [JsonProperty("method")]
        public ShippingMethod[] Method;

        [JsonProperty("address")]
        public ShippingAddress[] Address;

    }
}
