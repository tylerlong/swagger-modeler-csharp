using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class SyncInfo
    {

        [JsonProperty("syncTime")]
        public string SyncTime;

        [JsonProperty("syncToken")]
        public string SyncToken;

        [JsonProperty("syncType")]
        public string SyncType;

    }
}
