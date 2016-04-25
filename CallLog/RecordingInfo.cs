using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class RecordingInfo
    {

        [JsonProperty("contentUri")]
        public string ContentUri;

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("uri")]
        public string Uri;

    }
}
