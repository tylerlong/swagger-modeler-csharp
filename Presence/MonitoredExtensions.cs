using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Presence
{
    public class MonitoredExtensions
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public LineInfo[] Records;

        [JsonProperty("uri")]
        public string Uri;

    }
}
