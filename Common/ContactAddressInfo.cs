using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Common
{
    public class ContactAddressInfo
    {

        [JsonProperty("country")]
        public string Country;

        [JsonProperty("state")]
        public string State;

        [JsonProperty("city")]
        public string City;

        [JsonProperty("street")]
        public string Street;

        [JsonProperty("zip")]
        public string Zip;

    }
}
