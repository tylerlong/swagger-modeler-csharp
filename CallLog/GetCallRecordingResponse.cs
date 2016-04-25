using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class GetCallRecordingResponse
    {

        [JsonProperty("contentType")]
        public string ContentType;

        [JsonProperty("contentUri")]
        public string ContentUri;

        [JsonProperty("duration")]
        public int Duration;

        [JsonProperty("id")]
        public int Id;

    }
}
