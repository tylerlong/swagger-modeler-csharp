using Newtonsoft.Json;
using System;

namespace RingCentral.Models.BlockedNumbers
{
    public class GetBlockedNumberListResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public BlockedNumberInfo[] Records;

    }
}
