using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class MessagesEventPayload
    {

        [JsonProperty("body")]
        public MessagesEvent Body;

        [JsonProperty("event")]
        public string Event;

        [JsonProperty("timestamp")]
        public string Timestamp;

        [JsonProperty("uuid")]
        public string Uuid;

    }
}
