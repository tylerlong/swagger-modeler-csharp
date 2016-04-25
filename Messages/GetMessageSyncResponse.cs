using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class GetMessageSyncResponse
    {

        [JsonProperty("records")]
        public MessageInfo[] Records;

        [JsonProperty("syncInfo")]
        public SyncInfo SyncInfo;

    }
}
