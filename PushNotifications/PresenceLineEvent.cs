using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class PresenceLineEvent
    {

        [JsonProperty("extension")]
        public ExtensionInfo Extension;

        [JsonProperty("sequence")]
        public int Sequence;

    }
}
