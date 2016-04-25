using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class ServicePlanInfo
    {

        [JsonProperty("edition")]
        public string Edition;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

    }
}
