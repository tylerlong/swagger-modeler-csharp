using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class MessageAttachmentInfo
    {

        [JsonProperty("contentType")]
        public string ContentType;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("vmDuration")]
        public int VmDuration;

    }
}
