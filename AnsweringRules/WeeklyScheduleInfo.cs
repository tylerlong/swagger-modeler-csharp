using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class WeeklyScheduleInfo
    {

        [JsonProperty("friday")]
        public TimeInterval[] Friday;

        [JsonProperty("monday")]
        public TimeInterval[] Monday;

        [JsonProperty("saturday")]
        public TimeInterval[] Saturday;

        [JsonProperty("sunday")]
        public TimeInterval[] Sunday;

        [JsonProperty("thursday")]
        public TimeInterval[] Thursday;

        [JsonProperty("tuesday")]
        public TimeInterval[] Tuesday;

        [JsonProperty("wednesday")]
        public TimeInterval[] Wednesday;

    }
}
