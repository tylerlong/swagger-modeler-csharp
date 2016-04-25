using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class GetStateListQueryParameters
    {

        [JsonProperty("countryId")]
        public int CountryId;

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("withPhoneNumbers")]
        public boolean WithPhoneNumbers;

    }
}
