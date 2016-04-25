using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class ExtensionInfo
    {

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("uri")]
        public string Uri;

    }
}
