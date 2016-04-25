using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class DetailedPresenceEvent
    {

        [JsonProperty("extensionId")]
        public int ExtensionId;

        [JsonProperty("telephonyStatus")]
        public string TelephonyStatus;

        [JsonProperty("terminationType")]
        public string TerminationType;

        [JsonProperty("activeCalls")]
        public ActiveCallInfo[] ActiveCalls;

        [JsonProperty("sequence")]
        public int Sequence;

        [JsonProperty("presenceStatus")]
        public string PresenceStatus;

        [JsonProperty("userStatus")]
        public string UserStatus;

        [JsonProperty("dndStatus")]
        public string DndStatus;

        [JsonProperty("allowSeeMyPresence")]
        public boolean AllowSeeMyPresence;

        [JsonProperty("ringOnMonitoredCall")]
        public boolean RingOnMonitoredCall;

        [JsonProperty("pickUpCallsOnHold")]
        public boolean PickUpCallsOnHold;

    }
}
