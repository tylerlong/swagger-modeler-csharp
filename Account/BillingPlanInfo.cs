using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class BillingPlanInfo
    {

        [JsonProperty("duration")]
        public string Duration;

        [JsonProperty("durationUnit")]
        public string DurationUnit;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("type")]
        public string Type;

    }
}
