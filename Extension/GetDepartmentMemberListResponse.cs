using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class GetDepartmentMemberListResponse
    {

        [JsonProperty("records")]
        public Common.ExtensionInfo[] Records;

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

    }
}
