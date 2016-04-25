using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class GetExtensionListQueryParameters
    {

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("type")]
        public string Type;

    }
}
