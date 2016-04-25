using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class MessagesChanges
    {

        [JsonProperty("newCount")]
        public int NewCount;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("updatedCount")]
        public int UpdatedCount;

    }
}
