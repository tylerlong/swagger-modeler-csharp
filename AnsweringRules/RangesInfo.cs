using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class RangesInfo
    {

        [JsonProperty("from")]
        public string From;

        [JsonProperty("to")]
        public string To;

    }
}
