using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class CustomDataAttachmentInfo
    {

        [JsonProperty("contentType")]
        public string ContentType;

        [JsonProperty("uri")]
        public string Uri;

    }
}
