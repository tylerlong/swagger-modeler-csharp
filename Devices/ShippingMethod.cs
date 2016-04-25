using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Devices
{
    public class ShippingMethod
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

    }
}
