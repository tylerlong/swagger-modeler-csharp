using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class GetAccountActiveCallsQueryParameters
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
