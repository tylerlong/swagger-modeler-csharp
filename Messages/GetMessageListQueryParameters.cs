using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class GetMessageListQueryParameters
    {

        [JsonProperty("availability")]
        public string Availability;

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

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("readStatus")]
        public string ReadStatus;

    }
}
