using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class GetMessageSyncQueryParameters
    {

        [JsonProperty("conversationId")]
        public long ConversationId;

        [JsonProperty("dateFrom")]
        public string DateFrom;

        [JsonProperty("dateTo")]
        public string DateTo;

        [JsonProperty("direction")]
        public string Direction;

        [JsonProperty("distinctConversations")]
        public boolean DistinctConversations;

        [JsonProperty("messageType")]
        public string MessageType;

        [JsonProperty("recordCount")]
        public int RecordCount;

        [JsonProperty("syncToken")]
        public string SyncToken;

        [JsonProperty("syncType")]
        public string SyncType;

    }
}
