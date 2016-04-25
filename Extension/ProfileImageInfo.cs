using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class ProfileImageInfo
    {

        [JsonProperty("contentType")]
        public string ContentType;

        [JsonProperty("etag")]
        public string Etag;

        [JsonProperty("lastModified")]
        public string LastModified;

        [JsonProperty("scales")]
        public string[] Scales;

        [JsonProperty("uri")]
        public string Uri;

    }
}
