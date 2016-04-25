using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class LocationList
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public LocationInfo[] Records;

    }
}
