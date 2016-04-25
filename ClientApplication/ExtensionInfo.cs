using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class ExtensionInfo
    {

        [JsonProperty("extensionNumber")]
        public string ExtensionNumber;

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("uri")]
        public string Uri;

    }
}
