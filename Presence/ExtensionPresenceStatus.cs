using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Presence
{
    public class ExtensionPresenceStatus
    {

        [JsonProperty("allowSeeMyPresence")]
        public boolean AllowSeeMyPresence;

        [JsonProperty("dndStatus")]
        public string DndStatus;

        [JsonProperty("extension")]
        public ExtensionInfo Extension;

        [JsonProperty("message")]
        public string Message;

        [JsonProperty("pickUpCallsOnHold")]
        public boolean PickUpCallsOnHold;

        [JsonProperty("presenceStatus")]
        public string PresenceStatus;

        [JsonProperty("ringOnMonitoredCall")]
        public boolean RingOnMonitoredCall;

        [JsonProperty("telephonyStatus")]
        public string TelephonyStatus;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("userStatus")]
        public string UserStatus;

    }
}
