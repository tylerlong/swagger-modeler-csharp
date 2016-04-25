using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class GetCountryListQueryParameters
    {

        [JsonProperty("loginAllowed")]
        public boolean LoginAllowed;

        [JsonProperty("numberSelling")]
        public boolean NumberSelling;

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

    }
}
