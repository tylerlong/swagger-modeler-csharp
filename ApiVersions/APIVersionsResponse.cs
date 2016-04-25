using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ApiVersions
{
    public class APIVersionsResponse
    {

        [JsonProperty("apiVersions")]
        public VersionInfo[] ApiVersions;

        [JsonProperty("serverRevision")]
        public string ServerRevision;

        [JsonProperty("serverVersion")]
        public string ServerVersion;

        [JsonProperty("uri")]
        public string Uri;

    }
}
