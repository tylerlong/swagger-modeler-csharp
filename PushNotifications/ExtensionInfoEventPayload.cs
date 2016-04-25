using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class ExtensionInfoEventPayload
    {

        [JsonProperty("body")]
        public ExtensionInfoEvent Body;

        [JsonProperty("event")]
        public string Event;

        [JsonProperty("timestamp")]
        public string Timestamp;

        [JsonProperty("uuid")]
        public string Uuid;

    }
}
