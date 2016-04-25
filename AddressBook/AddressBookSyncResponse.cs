using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AddressBook
{
    public class AddressBookSyncResponse
    {

        [JsonProperty("nextPageId")]
        public int NextPageId;

        [JsonProperty("nextPageUri")]
        public string NextPageUri;

        [JsonProperty("records")]
        public PersonalContactInfo[] Records;

        [JsonProperty("syncInfo")]
        public SyncInfo SyncInfo;

    }
}
