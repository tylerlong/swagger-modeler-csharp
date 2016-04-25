using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class GetActiveCallsQueryParameters
    {

        [JsonProperty("direction")]
        public string Direction;

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("type")]
        public string Type;

    }
}
