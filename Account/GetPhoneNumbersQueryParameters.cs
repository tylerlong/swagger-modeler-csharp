using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class GetPhoneNumbersQueryParameters
    {

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("usageType")]
        public string UsageType;

    }
}
