using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class ActiveCallInfoWithSIP
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("direction")]
        public string Direction;

        [JsonProperty("from")]
        public string From;

        [JsonProperty("to")]
        public string To;

        [JsonProperty("telephonyStatus")]
        public string TelephonyStatus;

        [JsonProperty("sessionId")]
        public string SessionId;

        [JsonProperty("sipData")]
        public SIPData SipData;

    }
}
