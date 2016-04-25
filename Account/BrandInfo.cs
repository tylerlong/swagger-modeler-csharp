using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class BrandInfo
    {

        [JsonProperty("homeCountry")]
        public CountryInfo HomeCountry;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

    }
}
