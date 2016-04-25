using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class SecretQuestionList
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public SecretQuestionInfo[] Records;

        [JsonProperty("uri")]
        public string Uri;

    }
}
