using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class GetSpecialNumbersResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public SpecialNumberInfo[] Records;

    }
}
