using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class ForwardingInfo
    {

        [JsonProperty("notifyAdminSoftPhones")]
        public boolean NotifyAdminSoftPhones;

        [JsonProperty("notifyMySoftPhones")]
        public boolean NotifyMySoftPhones;

        [JsonProperty("ringingMode")]
        public string RingingMode;

        [JsonProperty("rules")]
        public RuleInfo[] Rules;

        [JsonProperty("softPhonesRingCount")]
        public int SoftPhonesRingCount;

    }
}
