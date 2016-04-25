using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class AnsweringRuleInfo
    {

        [JsonProperty("callHandlingAction")]
        public string CallHandlingAction;

        [JsonProperty("calledNumbers")]
        public CalledNumberInfo[] CalledNumbers;

        [JsonProperty("callers")]
        public CallersInfo[] Callers;

        [JsonProperty("enabled")]
        public boolean Enabled;

        [JsonProperty("forwarding")]
        public ForwardingInfo Forwarding;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("schedule")]
        public ScheduleInfo Schedule;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("unconditionalForwarding")]
        public UnconditionalForwardingInfo UnconditionalForwarding;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("voicemail")]
        public VoicemailInfo Voicemail;

    }
}
