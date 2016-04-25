using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class TargetServicePlanInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

    }
}
