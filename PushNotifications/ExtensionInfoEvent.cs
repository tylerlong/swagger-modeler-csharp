using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class ExtensionInfoEvent
    {

        [JsonProperty("eventType")]
        public string EventType;

        [JsonProperty("extensionId")]
        public int ExtensionId;

    }
}
