using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class DeleteMessageQueryParameters
    {

        [JsonProperty("conversationId")]
        public long ConversationId;

        [JsonProperty("purge")]
        public boolean Purge;

    }
}
