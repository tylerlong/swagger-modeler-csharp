using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ApiVersions
{
    public class APIVersionInfoResponse
    {

        [JsonProperty("releaseDate")]
        public string ReleaseDate;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("uriString")]
        public string UriString;

        [JsonProperty("versionString")]
        public string VersionString;

    }
}
