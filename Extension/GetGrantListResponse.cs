using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class GetGrantListResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public GrantInfo[] Records;

    }
}
