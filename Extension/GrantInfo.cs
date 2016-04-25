using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class GrantInfo
    {

        [JsonProperty("callMonitoring")]
        public boolean CallMonitoring;

        [JsonProperty("callPickup")]
        public boolean CallPickup;

        [JsonProperty("extension")]
        public ExtensionInfo Extension;

        [JsonProperty("uri")]
        public string Uri;

    }
}
