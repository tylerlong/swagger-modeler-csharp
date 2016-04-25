using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class GetAnsweringRulesListResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public AnsweringRuleInfo[] Records;

        [JsonProperty("uri")]
        public string Uri;

    }
}
