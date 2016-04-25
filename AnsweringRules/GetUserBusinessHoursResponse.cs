using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class GetUserBusinessHoursResponse
    {

        [JsonProperty("schedule")]
        public BusinessHoursScheduleInfo Schedule;

        [JsonProperty("uri")]
        public string Uri;

    }
}
