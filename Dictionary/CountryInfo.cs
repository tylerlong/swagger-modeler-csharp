using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
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

        [JsonProperty("loginAllowed")]
        public boolean LoginAllowed;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("numberSelling")]
        public boolean NumberSelling;

        [JsonProperty("uri")]
        public string Uri;

    }
}
