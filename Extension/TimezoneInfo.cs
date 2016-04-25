using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class TimezoneInfo
    {

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("uri")]
        public string Uri;

    }
}
