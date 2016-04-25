using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class IncomingCallEventPayload
    {

        [JsonProperty("event")]
        public string Event;

        [JsonProperty("uuid")]
        public string Uuid;

        [JsonProperty("timestamp")]
        public string Timestamp;

        [JsonProperty("extensionId")]
        public int ExtensionId;

        [JsonProperty("action")]
        public string Action;

        [JsonProperty("sessionId")]
        public string SessionId;

        [JsonProperty("serverId")]
        public string ServerId;

        [JsonProperty("from")]
        public string From;

        [JsonProperty("fromName")]
        public string FromName;

        [JsonProperty("to")]
        public string To;

        [JsonProperty("toName")]
        public string ToName;

        [JsonProperty("sid")]
        public string Sid;

        [JsonProperty("toUrl")]
        public string ToUrl;

        [JsonProperty("srvLvl")]
        public string SrvLvl;

        [JsonProperty("srvLvlExt")]
        public string SrvLvlExt;

        [JsonProperty("recUrl")]
        public string RecUrl;

    }
}
