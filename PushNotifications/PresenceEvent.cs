using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class PresenceEvent
    {

        [JsonProperty("allowSeeMyPresence")]
        public boolean AllowSeeMyPresence;

        [JsonProperty("dndStatus")]
        public string DndStatus;

        [JsonProperty("extensionId")]
        public int ExtensionId;

        [JsonProperty("pickUpCallsOnHold")]
        public boolean PickUpCallsOnHold;

        [JsonProperty("presenceStatus")]
        public string PresenceStatus;

        [JsonProperty("ringOnMonitoredCall")]
        public boolean RingOnMonitoredCall;

        [JsonProperty("sequence")]
        public int Sequence;

        [JsonProperty("telephonyStatus")]
        public string TelephonyStatus;

        [JsonProperty("terminationType")]
        public string TerminationType;

        [JsonProperty("userStatus")]
        public string UserStatus;

    }
}
