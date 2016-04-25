using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class UpdateMessageRequest
    {

        [JsonProperty("readStatus")]
        public string ReadStatus;

    }
}
