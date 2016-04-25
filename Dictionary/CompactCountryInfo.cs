using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class CompactCountryInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

    }
}
