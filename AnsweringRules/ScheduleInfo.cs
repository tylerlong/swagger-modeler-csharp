using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class ScheduleInfo
    {

        [JsonProperty("ranges")]
        public RangesInfo Ranges;

        [JsonProperty("ref")]
        public string Ref;

        [JsonProperty("weeklyRanges")]
        public WeeklyScheduleInfo WeeklyRanges;

    }
}
