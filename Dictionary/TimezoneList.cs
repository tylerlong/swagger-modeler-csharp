using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class TimezoneList
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public TimezoneInfo[] Records;

    }
}
