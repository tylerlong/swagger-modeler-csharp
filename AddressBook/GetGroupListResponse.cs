using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AddressBook
{
    public class GetGroupListResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public GroupInfo[] Records;

    }
}
