using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AddressBook
{
    public class GroupInfo
    {

        [JsonProperty("contactsCount")]
        public int ContactsCount;

        [JsonProperty("groupName")]
        public string GroupName;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("notes")]
        public string Notes;

        [JsonProperty("uri")]
        public string Uri;

    }
}
