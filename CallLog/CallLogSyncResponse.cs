using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class CallLogSyncResponse
    {

        [JsonProperty("records")]
        public CallLogRecord[] Records;

        [JsonProperty("syncInfo")]
        public SyncInfo SyncInfo;

    }
}
