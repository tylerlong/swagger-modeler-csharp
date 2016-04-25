using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class ShippingOptions
    {

        [JsonProperty("method")]
        public ShippingMethodInfo Method;

        [JsonProperty("price")]
        public int Price;

        [JsonProperty("quantity")]
        public int Quantity;

    }
}
