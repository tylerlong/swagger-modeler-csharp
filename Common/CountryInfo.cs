using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Common
{
    public class CountryInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("name")]
        public string Name;

    }
}
