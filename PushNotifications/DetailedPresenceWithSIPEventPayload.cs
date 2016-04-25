using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class DetailedPresenceWithSIPEventPayload
    {

        [JsonProperty("uuid")]
        public string Uuid;

        [JsonProperty("event")]
        public string Event;

        [JsonProperty("timestamp")]
        public string Timestamp;

        [JsonProperty("body")]
        public DetailedPresenceWithSIPEvent Body;

    }
}
