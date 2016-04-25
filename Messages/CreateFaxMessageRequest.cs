using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class CreateFaxMessageRequest
    {

        [JsonProperty("coverIndex")]
        public int CoverIndex;

        [JsonProperty("coverPageText")]
        public string CoverPageText;

        [JsonProperty("originalMessageId")]
        public string OriginalMessageId;

        [JsonProperty("resolution")]
        public string Resolution;

        [JsonProperty("sendTime")]
        public string SendTime;

        [JsonProperty("to")]
        public CallerInfo[] To;

    }
}
