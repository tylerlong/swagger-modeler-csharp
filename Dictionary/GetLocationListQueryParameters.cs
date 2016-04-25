using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class GetLocationListQueryParameters
    {

        [JsonProperty("orderBy")]
        public string OrderBy;

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("stateId")]
        public string StateId;

        [JsonProperty("withNxx")]
        public boolean WithNxx;

    }
}
