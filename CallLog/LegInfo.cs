using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class LegInfo
    {

        [JsonProperty("action")]
        public string Action;

        [JsonProperty("direction")]
        public string Direction;

        [JsonProperty("duration")]
        public int Duration;

        [JsonProperty("extension")]
        public ExtensionInfo Extension;

        [JsonProperty("from")]
        public CallerInfo From;

        [JsonProperty("legType")]
        public string LegType;

        [JsonProperty("recording")]
        public RecordingInfo Recording;

        [JsonProperty("result")]
        public string Result;

        [JsonProperty("startTime")]
        public string StartTime;

        [JsonProperty("to")]
        public CallerInfo To;

        [JsonProperty("transport")]
        public string Transport;

        [JsonProperty("type")]
        public string Type;

    }
}
