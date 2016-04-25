using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class CreatePagerMessageRequest
    {

        [JsonProperty("from")]
        public CallerInfo From;

        [JsonProperty("replyOn")]
        public int ReplyOn;

        [JsonProperty("text")]
        public string Text;

        [JsonProperty("to")]
        public CallerInfo[] To;

    }
}
