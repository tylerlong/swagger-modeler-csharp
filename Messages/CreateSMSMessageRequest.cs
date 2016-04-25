using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class CreateSMSMessageRequest
    {

        [JsonProperty("from")]
        public CallerInfo From;

        [JsonProperty("text")]
        public string Text;

        [JsonProperty("to")]
        public CallerInfo[] To;

    }
}
