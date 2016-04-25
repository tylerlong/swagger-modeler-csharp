using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Reporting
{
    public class RecurrenceInfo
    {

        [JsonProperty("pattern")]
        public string Pattern;

        [JsonProperty("value")]
        public string Value;

    }
}
