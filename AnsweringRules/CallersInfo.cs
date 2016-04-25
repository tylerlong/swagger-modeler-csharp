using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class CallersInfo
    {

        [JsonProperty("callerId")]
        public string CallerId;

        [JsonProperty("name")]
        public string Name;

    }
}
