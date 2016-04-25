using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class RuleInfo
    {

        [JsonProperty("forwardingNumbers")]
        public ForwardingNumberInfo[] ForwardingNumbers;

        [JsonProperty("index")]
        public int Index;

        [JsonProperty("ringCount")]
        public int RingCount;

    }
}
