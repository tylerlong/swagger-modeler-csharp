using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class ExtensionListEvent
    {

        [JsonProperty("eventType")]
        public string EventType;

        [JsonProperty("extensionId")]
        public int ExtensionId;

    }
}
