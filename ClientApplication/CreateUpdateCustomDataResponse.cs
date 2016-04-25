using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class CreateUpdateCustomDataResponse
    {

        [JsonProperty("attachment")]
        public CustomDataAttachmentInfo Attachment;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("value")]
        public string Value;

    }
}
