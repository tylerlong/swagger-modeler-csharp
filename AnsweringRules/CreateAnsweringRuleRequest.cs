using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class CreateAnsweringRuleRequest
    {

        [JsonProperty("callers")]
        public CallersInfo[] Callers;

        [JsonProperty("forwarding")]
        public ForwardingInfo Forwarding;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("type")]
        public string Type;

    }
}
