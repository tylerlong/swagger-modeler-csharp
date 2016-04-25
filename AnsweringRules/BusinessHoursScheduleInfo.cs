using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class BusinessHoursScheduleInfo
    {

        [JsonProperty("weeklyRanges")]
        public WeeklyScheduleInfo WeeklyRanges;

    }
}
