using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class GetPhoneNumbersResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public PhoneNumberInfo[] Records;

    }
}
