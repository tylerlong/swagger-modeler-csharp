using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class GetTimezoneListQueryParameters
    {

        [JsonProperty("page")]
        public string Page;

        [JsonProperty("perPage")]
        public string PerPage;

    }
}
