using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class GetPhoneNumberListResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public PhoneNumberInfo[] Records;

    }
}
