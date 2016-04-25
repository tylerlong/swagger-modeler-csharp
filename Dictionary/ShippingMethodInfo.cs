using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class ShippingMethodInfo
    {

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("name")]
        public string Name;

    }
}
