using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class MessagesEvent
    {

        [JsonProperty("extensionId")]
        public int ExtensionId;

        [JsonProperty("lastUpdated")]
        public string LastUpdated;

        [JsonProperty("changes")]
        public MessagesChanges Changes;

    }
}
