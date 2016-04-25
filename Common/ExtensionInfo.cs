using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Common
{
    public class ExtensionInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("extensionNumber")]
        public string ExtensionNumber;

        [JsonProperty("partnerId")]
        public string PartnerId;

    }
}
