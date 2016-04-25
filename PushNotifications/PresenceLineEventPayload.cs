using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class PresenceLineEventPayload
    {

        [JsonProperty("uuid")]
        public string Uuid;

        [JsonProperty("event")]
        public string Event;

        [JsonProperty("timestamp")]
        public string Timestamp;

        [JsonProperty("body")]
        public PresenceLineEvent Body;

    }
}
