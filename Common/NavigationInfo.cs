using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Common
{
    public class NavigationInfo
    {

        [JsonProperty("firstPage")]
        public string FirstPage;

        [JsonProperty("nextPage")]
        public string NextPage;

        [JsonProperty("previousPage")]
        public string PreviousPage;

        [JsonProperty("lastPage")]
        public string LastPage;

    }
}
