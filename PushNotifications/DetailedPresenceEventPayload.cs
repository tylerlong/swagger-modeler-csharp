using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class DetailedPresenceEventPayload
    {

        [JsonProperty("body")]
        public DetailedPresenceEvent Body;

        [JsonProperty("event")]
        public string Event;

        [JsonProperty("timestamp")]
        public string Timestamp;

        [JsonProperty("uuid")]
        public string Uuid;

    }
}
