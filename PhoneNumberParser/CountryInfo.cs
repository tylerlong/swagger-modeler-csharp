using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PhoneNumberParser
{
    public class CountryInfo
    {

        [JsonProperty("callingCode")]
        public string CallingCode;

        [JsonProperty("emergencyCalling")]
        public boolean EmergencyCalling;

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
