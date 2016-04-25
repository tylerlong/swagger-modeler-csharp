using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class GetMessageListResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public MessageInfo[] Records;

    }
}
