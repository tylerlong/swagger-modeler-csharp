using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class TimezoneInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("description")]
        public string Description;

    }
}
