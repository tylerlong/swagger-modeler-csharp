using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class DialingPlanCountryInfo
    {

        [JsonProperty("callingCode")]
        public string CallingCode;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("isoCode")]
        public string IsoCode;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("uri")]
        public string Uri;

    }
}
