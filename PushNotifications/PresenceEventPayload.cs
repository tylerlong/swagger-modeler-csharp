using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class PresenceEventPayload
    {

        [JsonProperty("body")]
        public PresenceEvent Body;

        [JsonProperty("event")]
        public string Event;

        [JsonProperty("timestamp")]
        public string Timestamp;

        [JsonProperty("uuid")]
        public string Uuid;

    }
}
