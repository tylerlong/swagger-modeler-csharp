using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class CallLogSyncQueryParameters
    {

        [JsonProperty("dateFrom")]
        public string DateFrom;

        [JsonProperty("recordCount")]
        public int RecordCount;

        [JsonProperty("statusGroup")]
        public string StatusGroup;

        [JsonProperty("syncToken")]
        public string SyncToken;

        [JsonProperty("syncType")]
        public string SyncType;

    }
}
