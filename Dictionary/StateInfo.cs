using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class StateInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("country")]
        public CompactCountryInfo Country;

        [JsonProperty("isoCode")]
        public string IsoCode;

        [JsonProperty("name")]
        public string Name;

    }
}
