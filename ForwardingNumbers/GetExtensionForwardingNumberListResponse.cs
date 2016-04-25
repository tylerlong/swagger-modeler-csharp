using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ForwardingNumbers
{
    public class GetExtensionForwardingNumberListResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public ForwardingNumberInfo[] Records;

    }
}
