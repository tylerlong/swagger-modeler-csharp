using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class CallLogRecord
    {

        [JsonProperty("action")]
        public string Action;

        [JsonProperty("direction")]
        public string Direction;

        [JsonProperty("duration")]
        public int Duration;

        [JsonProperty("from")]
        public CallerInfo From;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime;

        [JsonProperty("legs")]
        public LegInfo[] Legs;

        [JsonProperty("recording")]
        public RecordingInfo Recording;

        [JsonProperty("result")]
        public string Result;

        [JsonProperty("sessionId")]
        public string SessionId;

        [JsonProperty("startTime")]
        public string StartTime;

        [JsonProperty("to")]
        public CallerInfo To;

        [JsonProperty("transport")]
        public string Transport;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("uri")]
        public string Uri;

    }
}
