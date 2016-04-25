using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ForwardingNumbers
{
    public class GetExtensionForwardingNumberListQueryParameters
    {

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

    }
}
