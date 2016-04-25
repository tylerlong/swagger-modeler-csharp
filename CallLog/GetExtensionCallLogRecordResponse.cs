using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class GetExtensionCallLogRecordResponse
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

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("uri")]
        public string Uri;

    }
}
