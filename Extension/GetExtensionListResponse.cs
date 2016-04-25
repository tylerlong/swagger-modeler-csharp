using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class GetExtensionListResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public ExtensionInfo[] Records;

    }
}
