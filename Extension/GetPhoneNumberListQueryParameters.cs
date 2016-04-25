using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class GetPhoneNumberListQueryParameters
    {

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("usageType")]
        public string UsageType;

    }
}
