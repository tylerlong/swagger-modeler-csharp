using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class UpdateAnsweringRuleRequest
    {

        [JsonProperty("forwarding")]
        public ForwardingInfo Forwarding;

    }
}
