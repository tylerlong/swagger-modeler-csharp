using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class StateList
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public StateInfo[] Records;

    }
}
