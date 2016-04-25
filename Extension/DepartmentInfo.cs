using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class DepartmentInfo
    {

        [JsonProperty("extensionNumber")]
        public string ExtensionNumber;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

    }
}
