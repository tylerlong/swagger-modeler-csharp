using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AddressBook
{
    public class GetAddressBookQueryParameters
    {

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("sortBy")]
        public string SortBy;

        [JsonProperty("startsWith")]
        public string StartsWith;

    }
}
