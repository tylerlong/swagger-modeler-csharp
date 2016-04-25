using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AddressBook
{
    public class AddressBookSyncQueryParameters
    {

        [JsonProperty("pageId")]
        public int PageId;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("syncToken")]
        public string SyncToken;

        [JsonProperty("syncType")]
        public string SyncType;

    }
}
