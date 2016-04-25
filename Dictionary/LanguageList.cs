using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class LanguageList
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public LanguageInfo[] Records;

    }
}
