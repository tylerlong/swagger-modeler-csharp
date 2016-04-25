using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class BusinessAddressInfo
    {

        [JsonProperty("city")]
        public string City;

        [JsonProperty("country")]
        public string Country;

        [JsonProperty("state")]
        public string State;

        [JsonProperty("street")]
        public string Street;

        [JsonProperty("zip")]
        public string Zip;

    }
}
