using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class GetGrantListQueryParameters
    {

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

    }
}
