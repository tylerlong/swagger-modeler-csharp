using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Presence
{
    public class LineInfo
    {

        [JsonProperty("extension")]
        public ExtensionInfo Extension;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

    }
}
