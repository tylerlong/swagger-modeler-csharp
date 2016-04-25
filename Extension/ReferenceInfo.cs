using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class ReferenceInfo
    {

        [JsonProperty("ref")]
        public string Ref;

        [JsonProperty("type")]
        public string Type;

    }
}
