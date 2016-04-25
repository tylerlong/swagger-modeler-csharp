using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class GrantInfoExtensionInfo
    {

        [JsonProperty("extensionNumber")]
        public string ExtensionNumber;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("uri")]
        public string Uri;

    }
}
